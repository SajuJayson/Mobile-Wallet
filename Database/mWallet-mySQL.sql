DROP TABLE customers;
DROP TABLE accountInfo;
DROP TABLE transaction;
DROP TABLE login;

CREATE TABLE customers(
   CustomerID INT not null AUTO_INCREMENT,
   FirstName varchar (20),
   LastName varchar (30),
   EmailAddress varchar (100 ) NOT NULL,
   AccountNo varchar (30) NOT NULL,
   PRIMARY KEY (customerID)
);

CREATE TABLE accountInfo(
   AccountNo varchar(20) NOT NULL AUTO_INCREMENT,
   Balance decimal (20) NOT NULL,
   PRIMARY KEY (AccountNo)
);

CREATE TABLE transactionInfo(
   TansactionId varchar(20) null AUTO_INCREMENT,

   AccountNo varchar (30) NOT NULL,
   TransactionType varchar (10) NOT NULL, #add constrains(withdraw, deposit, transfer)
   Amount decimal (20) NOT NULL,
   TransactionTime datetime NOT NUll, # add current time/date as default value
   Status varchar (30) NOT NUll, #add constrains(finished, in process, unfinished)
   PRIMARY KEY (TansactionId),
   FOREIGN KEY (AccountNo) REFERENCES AccountInfo(AccountNo)
);

CREATE TABLE login(
   EmailAddress varchar (100 ) NOT NULL, 
   Password varchar(50) NOT NULL,
   FOREIGN KEY (EmailAddress) REFERENCES customers(EmailAddress)
);

INSERT INTO customers (firstName, lastName, emailAddress)
VALUES 
   ('Will','Zhang','devonzyx@gmail.com');


INSERT INTO accountInfo (balance)
VALUES
   (1000000.00),
   (123456.00);

INSERT INTO transactionInfo (TransactionType,Amount,Status)
VALUES
   ('withdraw',100.00,'in process'),
   ('deposit',200.00,'double');


