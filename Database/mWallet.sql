DROP TABLE customers;
DROP TABLE accountInfo;
DROP TABLE transaction;
DROP TABLE login;

CREATE TABLE customers(
   CustomerID INT not null 
        GENERATED ALWAYS AS IDENTITY
        (START WITH 100, INCREMENT BY 1), 
   FirstName varchar (20),
   LastName varchar (30),
   EmailAddress varchar (100 ) NOT NULL,
   AccountNo varchar (30) NOT NULL,
   PRIMARY KEY (customerID)
);

CREATE TABLE accountInfo(
   AccountNo varchar NOT NULL 
         GENERATED ALWAYS AS IDENTITY
         (START WITH 1, INCREMENT BY 1),
   Balance decimal (20) NOT NULL,
   PRIMARY KEY (AccountNo)
);

CREATE TABLE transaction(
   TansactionId varchar not null 
        GENERATED ALWAYS AS IDENTITY
        (START WITH 1, INCREMENT BY 1), 
   AccountNo varchar (30) NOT NULL FOREIGN KEY REFERENCES AccountInfo(AccountNo),
   TransactionType varchar (10) NOT NULL ,--add constrains(withdraw, deposit, transfer)
   Amount decimal (20) NOT NULL,
   TransactionTime datetime (20) NOT NUll DEFAULT GETDATE(), --current time/date as default value
   Status varchar (30) NOT NUll, --add constrains(finished, in process, unfinished)
   PRIMARY KEY (TansactionId)   
);

CREATE TABLE login(
   EmailAddress varchar (100 ) NOT NULL FOREIGN KEY REFERENCES customers(EmailAddress), 
   Password varchar(50) NOT NULL,
);

INSERT INTO customers (firstName, lastName, emailAddress)
VALUES 
   ('Will','Zhang','devonzyx@gmail.com');


INSERT INTO transaction (balance)
VALUES
   (1000000.00),
   (123456.00);

INSERT INTO accountInfo (TransactionType,Amount,Status)
VALUES
   ('withdraw',100.00,'in process'),
   ('deposit',200.00,'double');


