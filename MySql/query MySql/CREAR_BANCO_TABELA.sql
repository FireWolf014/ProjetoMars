CREATE DATABASE CRMZAPEX;


CREATE TABLE sys_usr 
(
	USR_ID INT NOT NULL AUTO_INCREMENT,
	USR_USER VARCHAR(10) NOT NULL,
	USR_NOME VARCHAR(20) NOT NULL,
	USR_PWD	VARCHAR(20) NOT NULL,
	USR_EMAIL VARCHAR(20) NOT NULL,
	USR_DEPARTAMENTO VARCHAR(20) NOT NULL,
	USR_CARGO VARCHAR(20) NOT NULL,
	USR_GRUPO INT NOT NULL,
	USR_BLQ INT NOT NULL,
	PRIMARY KEY USR_ID
);