/*
	데이터 저장을 위한 SQL문
    센서의 값을 저장하는 sensors,
    희망 온도와 희망 습도를 입력받는
    desire_temp_wet_table 
    두 개의 테이블을 정의해준다.
*/
create database php_db;

Use php_db;

create table sensors(
AI int not null auto_increment primary key,
tmp int, wet int, data_day datetime
);

create table desire_temp_wet_table(
ins_order int auto_increment primary key,
desire_temp int, desire_wet int);
