#include <arduino-timer.h>

volatile int timer_counter = 0;
auto timer = timer_create_default();

bool toggle_led(void *) 
{
  timer_counter++;
  digitalWrite(LED_BUILTIN, !digitalRead(LED_BUILTIN)); // toggle the LED
  return true; // repeat? true
}
//analogRead(2);
//analogRead(3);
//analogRead(4);

int sensordata[5]; // current sensor value
int desire_temp[5]= {10,10,10,10,10}; // 초기 희망온도. default desire temp/wet value = 10

String rxStr = ""; // uart rx data를 저장하는 공간
bool rx_message_detect_flag = 0; // if new line detect, then set 1

int ledpin = 4;

void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  timer.every(1000, toggle_led);
}

// 타이머  시간 = x*y(밀리초) ; timer.every(x),timer_conunter(y)

void loop() 
{

  if(sensordata[2] >= desire_temp[2])
    analogWrite(2,255);
  if(sensordata[2] < desire_temp[2])
    analogWrite(2,0);
  if(sensordata[3] >= desire_temp[3])
    analogWrite(3,255);
  if(sensordata[3] < desire_temp[3])
    analogWrite(3,0);
   if(sensordata[4] >= desire_temp[4])
    analogWrite(4,255);
  if(sensordata[4] < desire_temp[4])
    analogWrite(4,0);
    
  // polling 방식  : 사용자 program에서 주기적으로 호출해서 실행하는 방식
  //                 프로그램에 load(부하)가 많이 걸리면 프로그램이 늦게 실행되어
  //                 들어온 데이터를 즉각 처리하지 못하고 지연되어 데이터를 손실할 우려가 있다.
  //                 일반적으로 interrupt 방식이 더 우수함.
  //                
  // interrupt 방식 : HW 가 SW 한테 직접 알려주는 방식
  //                데이터가 들어오면 SW 함수를 호출해서 실행
  
  if(Serial.available()) //pc로부터 들어온 데이터가 존재하면 실행
  {
    char data = Serial.read(); // uart 로부터 1byte를 읽는다
    rxStr += data;  // 읽어온 1byte 데이터를 rxStr에 저장
    
    if (data == '\n') // 현재 들어온 데이터가 newline 일 때
    {
      rx_message_detect_flag = true; // rx_message_detect_flag를 1로 세팅  
    }
  }

  if(rx_message_detect_flag) // if(rx_message_detect_flag ==1)
  {
    rx_message_detect_flag = 0;
    if(rxStr.compareTo("desire_temp:")) // desire_temp:10:10:10:\n
    {
      int first=11; //첫 번째 토큰의 위치 ( d0e1s2i3r4e5...)
      int second = rxStr.indexOf(":",first+1); // 두 번째 토큰의 위치
      int third = rxStr.indexOf(":",second+1); // 세 번째 토큰의 위치
      int fourth = rxStr.indexOf(":",third+1); // 네 번째 토큰의 위치

      String str1 = rxStr.substring(first+1,second);
      String str2 = rxStr.substring(second+1,third);
      String str3 = rxStr.substring(third+1,fourth);

      desire_temp[2] = str1.toInt();
      desire_temp[3] = str2.toInt();
      desire_temp[4] = str3.toInt();

      Serial.print(rxStr);
    }
    rxStr = ""; // 버퍼 clear
  }
  
  if(timer_counter>=1)
  {
    timer_counter=0;

    sensordata[0] = analogRead(A0); // temperature 
    sensordata[0] = map(sensordata[0],0,1023,0,40);
    sensordata[1] = analogRead(A1); // humidity
    sensordata[1] = map(sensordata[1],0,1023,0,80);

    sensordata[2] = analogRead(A2);  // room1
    sensordata[2] = map(sensordata[2],0,1023,0,40);
    sensordata[3] = analogRead(A3);  // room2
    sensordata[3] = map(sensordata[3],0,1023,0,40);
    sensordata[4] = analogRead(A4);  // room3
    sensordata[4] = map(sensordata[4],0,1023,0,40);
    
    // Sensor:x:y:z:\n
    Serial.print("temperature:"+(String)sensordata[0]+"\n");
    Serial.print(" humidity:"+(String)sensordata[1]+"\n");

    // 현재 온도 : curr_temp:10:20:15:\n
    // 희망 온도 : desire_temp:10:10:10:\n
    Serial.print(" curr_temp:"+(String)sensordata[2]+":"+(String)sensordata[3]+":"+(String)sensordata[4]+":\n");
    Serial.print(" desire_temp:"+(String)desire_temp[2]+":"+(String)desire_temp[3]+":"+(String)desire_temp[4]+":\n");
  }
  timer.tick(); // tick the timer
}
