-- Active: 1669695164409@@rcmforg.mysql.database.azure.com@3306@rcmforg
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS players(
  id VARCHAR(255) NOT NULL primary key AUTO_INCREMENT,
  name varchar(255),
  email varchar(255),
  picture varchar(255)
) default charset utf8 COMMENT '';


