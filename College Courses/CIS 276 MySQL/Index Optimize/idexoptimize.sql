/******************************
This assignment has you create 3 tables
Insert data into tables (will need about 40 books and at least 20 authors)
Run queries with explain, remove/alter indices, and run them again ;)
calculate optimal index length on title field

Interesting reference:
http://www.slideshare.net/techdude/how-to-kill-mysql-performance
****************************/

create table authors (
author_id INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
fname  varchar(50),
lname  varchar(50)
) character set utf8 collate utf8_unicode_ci engine = InnoDB;

create table books (
book_id INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
title varchar(200),
yearpub DATE
)character set utf8 collate utf8_unicode_ci engine = InnoDB;

/*note you can create the FK's directly with the table, or add them later */
create table authors_books (
author_id INT unsigned,
INDEX (author_id),
book_id INT unsigned,
INDEX (book_id),
editor enum('primary','secondary','no')
)character set utf8 collate utf8_unicode_ci engine = InnoDB;

ALTER TABLE authors_books ADD FOREIGN KEY (author_id) REFERENCES `authors` (author_id);
ALTER TABLE authors_books ADD FOREIGN KEY (book_id) REFERENCES `books` (book_id);
/*Another way to add foreign keys
alter table author_books add constraint fk_1 foreign key (author_id) references authors (author_id);
alter table author_books add constraint fk_2 foreign key (book_id) references books (book_id);
*/
alter table authors_books add primary key (author_id, book_id);

/*You need to add at least 20 authors */
INSERT INTO authors values
(NULL, 'Phil', 'Waclawski'),
(NULL, 'Al', 'Einstein'),
(NULL, 'Genghis', 'Kahn'),
(NULL, 'Stephen', 'Hawking');

INSERT INTO authors values
(NULL, 'Beelzebub', 'Satanson'),
(NULL, 'George', 'Carlin'),
(NULL, 'The', 'Situation'),
(NULL, 'Bill', 'Clinton'),
(NULL, 'Mitt', 'Romney'),
(NULL, 'Clint', 'Eastwood'),
(NULL, 'George W.', 'Bush'),
(NULL, 'Osama', 'Bin Laden'),
(NULL, 'Jesus', 'Christ'),
(NULL, 'Yaweh', 'the Almighty'),
(NULL, 'Mohammed', 'the Prophet'),
(NULL, 'Salman', 'Rushdie'),
(NULL, 'Gilbert', 'Gottfrey'),
(NULL, 'Alex', 'Kolar'),
(NULL, 'Sherman', 'Klump'),
(NULL, 'Adam', 'Sandler'),
(NULL, 'Larry', 'the Cable Guy'),
(NULL, 'Jeff', 'Foxworthy'),
(NULL, 'Abraham', 'Lincoln'),
(NULL, 'Donald', 'Trump');

/*NOTE, you need to add a total of 40 book titles */ 

INSERT INTO books  values
(NULL, 'Black Holes and You', '2004-01-23'),
(NULL, 'Its all relative', '1945-03-31'),
(NULL, 'How to know when you have overstayed your welcome', '1111-02-21'),
(NULL, 'The Bright Side of Dark Matter', '2002-03-15'),
(NULL, 'I Hope This Bloody Nose Doesnt Kill Me', '1227-08-23'),
(NULL, 'How to Kill Yourself if You Are Paralyzed', '2001-11-14'),
(NULL, 'How to Become a Ferret Whisperer', '2020-06-21'),
(NULL, 'So Youre a Ferret Whisperer. Now What?', '2024-05-19'),
(NULL, 'How to Ignore those Pesky Ferrets', '2030-02-13'),
(NULL, 'Where We Hide Your Gold', '1951-10-16'),
(NULL, 'Why I Dont Deserve to Rot In Hell, and Why You Dont, Either', '0001-01-01'),
(NULL, 'God Bless America, Mexico, the Sudan, Iraq, and Everyone Else', '1987-10-01'),
(NULL, 'Why You Should Never Watch the Jersey Shore', '2018-04-29'),
(NULL, 'How Not to Have an Affair', '1990-11-17'),
(NULL, 'How to Fire Millions and Still Call Yourself a Job-Creator', '2013-12-25'),
(NULL, 'What Did You Say, Punk?', '1956-08-10'),
(NULL, 'America Needs to be Less Free In Order to Stay Free (A Defense of the PATRIOT Act)', '2004-01-05'),
(NULL, 'You Know Damn Well the Saudis Took Down those Towers, so Stop Trying to Kill Me!', '2009-03-21'),
(NULL, 'If You Want to Follow Me, Oppose those Who Preach in My Name', '1250-11-02'),
(NULL, 'I Created the Entire Universe. What Makes You Think I Need Your Help to Defend My Honor?', '1742-02-27'),
(NULL, 'The Koran', '1000-05-25'),
(NULL, 'I Wrote the Koran while I was Starved out of my Mind. Please Dont Take it Seriously', '1001-04-22'),
(NULL, 'Please Read Mohammeds Second Book Before You Carry Out the Fatwa on my Head', '2010-07-17'),
(NULL, 'Once a Joke Becomes Offensive, It Becomes Hilarious. So Stop Pretending Otherwise.', '2013-10-31'),
(NULL, 'Why Im Better Than You, and Why My Death Wont Stop My Message', '2015-01-29'),
(NULL, 'Fatzilla', '1990-12-01'),
(NULL, 'Fatzilla Visits Washington', '1991-08-12'),
(NULL, 'Fatzilla VS. Godzilla', '1993-02-28'),
(NULL, 'Fatzilla Gets Skinny', '1996-05-14'),
(NULL, 'Why Acting Like a Child is Funny at all Times', '2009-10-10'),
(NULL, 'My Sister Is Covered In Moles', '2009-10-10'),
(NULL, 'If you Look Like Larry the Cable Guy, You Might Not be a Redneck', '2010-11-13'),
(NULL, 'Comedy is so Easy a Redneck can do it', '2011-09-09'),
(NULL, 'Slavery Wasnt Always on the Agenda', '1860-10-20'),
(NULL, 'A House Divided Cannot Stand', '1861-03-11'),
(NULL, 'Greed is Not a Vice, Short-Sightedness is', '2011-01-01'),
(NULL, 'My Toupee Is Firing Me', '2015-07-22'),
(NULL, 'How to Fire People Like I do', '1991-04-02'),
(NULL, 'Why Mitt Romney Would Sell us all to China', '2011-12-11'),
(NULL, 'Top Ten Reasons Why I Fire People', '1995-06-05'),
(NULL, 'My Hair is Not a Raccoon, Its a Squirrel', '1996-08-16'),
(NULL, 'Ferrets will Dominate the Earth', '2105-06-24'),
(NULL, 'I have my own ferret army. It does my bidding.', '2301-04-26'),
(NULL, 'How to know when you talk about your ferrets too much', '2255-07-14');

/* some inserts to help you with join table */
INSERT INTO authors_books ( author_id, book_id, editor)
(select author_id, book_id ,'primary' from authors, books where fname='Osama' 
AND lname='Bin Laden' AND title LIKE '%Towers%');

INSERT INTO authors_books ( author_id, book_id, editor)
(select author_id, book_id ,'primary' from authors, books where  
fname='Donald' AND title LIKE 'Greed%');

INSERT INTO authors_books ( author_id, book_id, editor)
(select author_id, book_id ,'primary' from authors, books 
where (fname='Al' 
AND lname='Einstein') AND title LIKE '%relative');

/*Five queries to try out  using explain and different indices*/

select a.fname, a.lname, b.title, b.yearpub, ab.editor 
from authors a JOIN authors_books ab USING(author_id)
JOIN books b USING (book_id)
where fname='Al' AND lname='Einstein'
AND title LIKE '%Black%';

select a.fname, a.lname, b.title, b.yearpub, ab.editor 
from authors a JOIN authors_books ab USING(author_id)
JOIN books b USING (book_id)
where lname='Einstein' AND fname='Al'
AND title LIKE '%Black%';

select a.fname, a.lname, b.title, b.yearpub, ab.editor 
from authors a JOIN authors_books ab USING(author_id)
JOIN books b USING (book_id)
where lname='Einstein'
AND title LIKE '%Black%';

select a.fname, a.lname, b.title, b.yearpub, ab.editor 
from authors a JOIN authors_books ab USING(author_id)
JOIN books b USING (book_id)
where fname='Al'
AND title LIKE '%Black%';

/*this one allows the title index to work */
select a.fname, a.lname, b.title, b.yearpub, ab.editor 
from authors a JOIN author_books ab USING(author_id)
JOIN books b USING (book_id)
where lname='Einstein' AND fname='Al'
AND title LIKE 'Black%';

/*************************************

NOTE: Keep in mind that MySQL uses leftmost prefix indexing on multiple
column indexes
http://www.databasejournal.com/features/mysql/article.php/10897_1382791_3/Optimizing-MySQL-Queries-and-Indexes.htm

**********************************************/


/* use parentheses to join appropriate AND and OR statements */
* Some additional methods of trying to optimize your database */

set profiling = 1;
/* run a query 
   then immediately do
   the following: */
   
show profile;

/*  Figuring out optimal index length on a text field
http://fernandoipar.com/2009/08/12/indexing-text-columns-in-mysql/
*/

 select * from table_name procedure analyse(0,0)\G
/* to see  your indices on a table */
 show index from table_name;
 
 /* several ways to try and figure out optimal key length 
 	as our books table has a varchar(200) and the analyze
 	says the optimale would be a varchar(53) try the following
 	commands...
 */
 select count(distinct(substr(title,1,200))) / 
 count(distinct(title)) * 100 from books;
 select count(distinct(substr(title,1,53))) / 
 count(distinct(title)) * 100 from books;
 select count(distinct(substr(title,1,20))) / 
 count(distinct(title)) * 100 from books;
 select count(distinct(substr(title,1,21))) / 
 count(distinct(title)) * 100 from books;
 
 /*This one works the best*/
 select count(distinct(substr(title,1,22))) / 
 count(distinct(title)) * 100 from books;
 
/* ASSIGNMENT
You may have to delete tables and recreate from time to time
use the  following type of indices (index)  along with the parentheses and not
and use the \G switch with explain
FIRST: Add about 40 fields to authors and books
1.  INDEX on LNAME, then remove LNAME and add an INDEX on FNAME (run explain both
times)
2. INDEX on LNAME AND FNAME  (but not a combined index) run explain
3. combined index on LNAME and FNAME
4. combined index on lname, fname, and then an index on title
5. Try to make an index on title of varying length (first 10 chars, 20 chars?)
6. how else to improve this query?
7. use the count distinct trick above to figure out optimal index length on title field
(and paste results into file, post file on our class website)
