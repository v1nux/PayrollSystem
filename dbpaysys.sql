-- create table loginCreds (
--  id INT AUTO_INCREMENT PRIMARY KEY,
--     userRole VARCHAR(10) NOT NULL, -- whether admin, employee or manager.
--     personalID VARCHAR(30) UNIQUE NOT NULL,
--     fname VARCHAR(50) NOT NULL,
--     mname VARCHAR(50),
--     lname VARCHAR(50) NOT NULL,
--     logUser VARCHAR(50) UNIQUE NOT NULL,
--     logPass VARCHAR(50) NOT NULL
-- );

-- insert into loginCreds (userRole,personalID,fname,mname,lname,logUser,logPass)
-- VALUES
-- ('admin','1-0000000002', 'Jane', 'Doe', 'Smith', 'admin', '123');

insert into loginCreds (userRole,personalID,fname,mname,lname,logUser,logPass)
VALUES
('employee','2-0000000003', 'Swiper', 'No', 'Swiping', 'fox', '123');

select * from loginCreds;