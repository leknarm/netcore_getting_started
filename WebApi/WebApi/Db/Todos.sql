CREATE TABLE Todos (
	Id int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	Todo varchar(500) NOT NULL,
	DueDate datetime NOT NULL,
	CreatedDate datetime NOT NULL
)