﻿DECLARE @UserStaging TABLE
(
   FirstName NVARCHAR(34) NOT NULL,
   LastName NVARCHAR(34) NOT NULL,
   PhoneNumber NVARCHAR(14) NOT NULL,
   CreatedOn DATETIMEOFFSET NOT NULL,
   UpdatedOn DATETIMEOFFSET NOT NULL,
   LastCheckOutDate DateTime2 NOT NULL,
   IsDeleted TINYINT NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @UserStaging(FirstName,LastName,PhoneNumber,CreatedOn,UpdatedOn, LastCheckOutDate,IsDeleted)
VALUES
 (N'Colette', N'Forbes', N'(512) 495-5216', '2015-08-29', '2015-08-29', '2018-02-03', 0 ),
 (N'Ashton', N'Hurley', N'(453) 422-7165', '2015-08-12', '2019-11-10', '2020-11-28', 0 ),
 (N'Elton', N'Salinas', N'(199) 984-6536', '2019-05-19', '2019-08-11', '2019-08-12', 0 ),
 (N'Naomi', N'Wright', N'(927) 312-9535', '2016-01-08', '2018-01-22', '2018-03-10', 0 ),
 (N'Derek', N'Hudson', N'(631) 426-7246', '2019-12-28', '2019-12-28', '2021-01-01', 0 ),
 (N'Ronan', N'Walls', N'(667) 617-4921', '2019-11-11', '2019-11-11', '2019-11-11', 0 ),
 (N'Rhona', N'Newton', N'(564) 706-8364', '2015-07-21', '2016-03-02', '2019-11-10', 0 ),
 (N'Merritt', N'Evans', N'(245) 247-3260', '2017-05-16', '2017-05-16', '2020-08-18', 0 ),
 (N'Harding', N'Adkins', N'(832) 560-5822', '2018-12-07', '2021-01-25', '2021-01-25', 1 ),
 (N'Brennan', N'Burns', N'(904) 416-7400', '2020-01-03', '2020-01-03', '2020-01-03', 0 ),
 (N'Orli', N'Ayers', N'(702) 362-1809', '2016-06-24', '2021-01-17', '2021-01-17', 0 ),
 (N'Alden', N'Holt', N'(800) 742-9805', '2015-06-29', '2018-09-08', '2018-12-17', 1 ),
 (N'Clarke', N'Hicks', N'(771) 210-0778', '2016-05-13', '2016-05-13', '2020-03-15', 0 ),
 (N'Austin', N'Allison', N'(330) 207-3101', '2017-06-21', '2017-07-11', '2019-07-16', 0 ),
 (N'Belle', N'Poole', N'(576) 193-9584', '2020-10-22', '2021-01-05', '2021-01-05', 0 ),
 (N'Bernard', N'Camacho', N'(874) 409-4105', '2016-04-24', '2017-06-30', '2017-12-17', 0 ),
 (N'Virginia', N'Battle', N'(765) 196-3049', '2016-05-30', '2016-05-30', '2018-08-04', 0 ),
 (N'Dawn', N'Jackson', N'(219) 999-7577', '2018-12-09', '2019-04-05', '2019-11-09', 0 ),
 (N'Latifah', N'Peters', N'(930) 553-0973', '2020-05-15', '2020-11-02', '2021-01-17', 1 ),
 (N'Walter', N'Gilliam', N'(665) 359-8493', '2016-02-25', '2018-10-14', '2020-11-14', 0 ),
 (N'Abdul', N'Guy', N'(188) 196-7479', '2017-08-30', '2020-06-01', '2020-06-01', 0 ),
 (N'Melanie', N'Durham', N'(811) 633-0755', '2017-06-20', '2017-11-28', '2018-12-18', 0 ),
 (N'Carissa', N'Reed', N'(764) 217-5034', '2017-10-13', '2018-10-13', '2020-04-18', 0 ),
 (N'Yuli', N'Burgess', N'(471) 834-8768', '2019-05-06', '2021-04-03', '2021-04-03', 0 ),
 (N'Patience', N'Olsen', N'(430) 700-9711', '2017-04-18', '2018-02-08', '2021-02-25', 0 ),
 (N'Merritt', N'Barnett', N'(773) 641-8806', '2017-04-28', '2017-06-29', '2021-02-27', 0 ),
 (N'Raymond', N'Diaz', N'(323) 172-3053', '2017-11-28', '2019-01-06', '2019-10-04', 0 ),
 (N'Troy', N'Kennedy', N'(610) 973-3813', '2015-11-02', '2015-11-02', '2021-01-14', 0 ),
 (N'Mary', N'Faulkner', N'(297) 301-6296', '2017-06-11', '2019-06-26', '2019-06-26', 0 ),
 (N'Steel', N'Brock', N'(652) 608-8152', '2016-08-26', '2016-08-26', '2020-03-01', 0 ),
 (N'Abra', N'Moore', N'(365) 458-7134', '2016-10-15', '2019-06-29', '2020-04-16', 0 ),
 (N'Hasad', N'Sloan', N'(235) 708-0544', '2018-02-08', '2018-02-08', '2018-08-20', 0 ),
 (N'Camden', N'Valdez', N'(300) 521-8668', '2020-01-04', '2021-01-19', '2021-04-20', 0 ),
 (N'Chaim', N'Mendez', N'(763) 424-2023', '2019-04-05', '2019-04-05', '2021-02-06', 0 ),
 (N'Dalton', N'Ford', N'(610) 398-8513', '2017-07-12', '2017-07-12', '2020-05-30', 0 ),
 (N'Harrison', N'Mosley', N'(698) 708-1670', '2016-08-04', '2018-01-26', '2020-11-16', 0 ),
 (N'Ahmed', N'Dale', N'(567) 256-8576', '2019-05-08', '2019-05-08', '2021-02-11', 0 ),
 (N'Hayes', N'Chavez', N'(896) 904-4210', '2017-10-09', '2017-10-09', '2020-02-23', 0 ),
 (N'Aiko', N'Richardson', N'(697) 707-5956', '2015-08-11', '2017-06-19', '2019-07-11', 0 ),
 (N'Axel', N'Vazquez', N'(999) 818-0918', '2017-07-11', '2017-07-10', '2019-06-25', 0 ),
 (N'Daryl', N'Mercado', N'(154) 216-8499', '2017-12-02', '2019-09-28', '2020-06-30', 1 ),
 (N'Dolan', N'Bullock', N'(172) 527-9938', '2018-09-06', '2018-09-06', '2020-10-05', 0 ),
 (N'Felicia', N'Sloan', N'(369) 554-6882', '2016-02-23', '2017-12-10', '2018-02-26', 0 ),
 (N'Yuli', N'Espinoza', N'(680) 815-9665', '2015-09-13', '2017-12-29', '2020-04-05', 0 ),
 (N'Omar', N'Whitfield', N'(679) 363-6900', '2016-09-10', '2019-06-30', '2019-08-25', 0 ),
 (N'Clare', N'May', N'(110) 391-5050', '2017-12-22', '2018-03-15', '2018-03-15', 1 ),
 (N'Timon', N'Tucker', N'(977) 391-2686', '2018-01-26', '2019-07-24', '2019-07-24', 0 ),
 (N'Kareem', N'Hammond', N'(392) 948-8632', '2015-06-29', '2015-06-29', '2020-09-01', 0 ),
 (N'Declan', N'Hull', N'(332) 444-3983', '2015-12-03', '2017-04-23', '2019-05-30', 1 ),
 (N'Chanda', N'Cruz', N'(253) 180-9621', '2017-08-07', '2019-02-02', '2020-04-05', 0 ),
 (N'Rafael', N'Koch', N'(715) 699-2108', '2019-03-10', '2020-01-04', '2021-03-28', 0 ),
 (N'Eaton', N'Solomon', N'(211) 961-1037', '2016-08-21', '2019-01-14', '2020-01-02', 0 ),
 (N'Michelle', N'Bauer', N'(184) 572-9768', '2018-12-10', '2018-12-10', '2021-02-06', 0 ),
 (N'Belle', N'Barker', N'(141) 756-7680', '2018-10-27', '2018-10-27', '2020-05-08', 0 ),
 (N'Castor', N'Stevens', N'(272) 957-7773', '2015-11-17', '2016-11-18', '2020-11-23', 0 ),
 (N'Rebecca', N'Booker', N'(146) 439-6700', '2018-11-17', '2018-11-17', '2020-03-03', 0 ),
 (N'Marny', N'Donovan', N'(849) 124-2963', '2016-05-16', '2018-01-28', '2020-12-24', 0 ),
 (N'Yuli', N'Dunn', N'(630) 448-9711', '2020-04-05', '2020-04-05', '2020-10-16', 0 ),
 (N'Isadora', N'Bennett', N'(191) 153-6707', '2015-12-24', '2015-12-24', '2018-03-04', 0 ),
 (N'Boris', N'Arnold', N'(186) 681-8371', '2017-04-04', '2018-08-23', '2021-02-14', 0 ),
 (N'Simon', N'Monroe', N'(704) 181-7038', '2017-12-11', '2017-12-11', '2020-11-26', 0 ),
 (N'Rylee', N'Bolton', N'(598) 127-3712', '2017-04-05', '2017-04-05', '2019-01-27', 1 ),
 (N'Elvis', N'Daniels', N'(906) 261-7654', '2016-07-30', '2018-11-22', '2019-08-25', 0 ),
 (N'April', N'Bradford', N'(603) 240-6455', '2018-10-17', '2018-10-17', '2020-01-25', 0 ),
 (N'Reese', N'Wilder', N'(421) 963-2187', '2019-01-02', '2019-01-02', '2019-09-19', 1 ),
 (N'Vaughan', N'Mcpherson', N'(731) 251-9212', '2017-12-16', '2018-06-16', '2020-07-03', 0 ),
 (N'Sheila', N'George', N'(138) 178-1746', '2016-09-19', '2016-09-19', '2018-02-12', 0 ),
 (N'Robert', N'Paul', N'(392) 185-4669', '2015-05-01', '2015-05-01', '2020-11-30', 0 ),
 (N'Willa', N'Franklin', N'(296) 584-8678', '2017-03-28', '2017-05-21', '2018-06-26', 0 ),
 (N'Nicole', N'Gaines', N'(557) 317-4902', '2017-02-03', '2017-03-05', '2021-04-11', 1 ),
 (N'Fay', N'Hawkins', N'(525) 785-7008', '2017-08-11', '2018-03-10', '2018-11-01', 0 ),
 (N'Hermione', N'Mcdowell', N'(283) 869-6333', '2016-10-02', '2017-05-13', '2020-09-24', 0 ),
 (N'Francesca', N'Cline', N'(652) 374-7779', '2016-11-18', '2020-12-06', '2020-04-18', 0 ),
 (N'Kaye', N'Mooney', N'(917) 642-1457', '2018-01-29', '2018-08-21', '2021-03-28', 0 ),
 (N'Sybill', N'Goff', N'(870) 114-4755', '2017-03-01', '2017-03-01', '2019-04-13', 0 ),
 (N'Nita', N'Olsen', N'(489) 373-2384', '2017-07-28', '2017-07-28', '2019-02-28', 0 ),
 (N'Isaac', N'Peck', N'(280) 596-5120', '2018-08-23', '2018-08-23', '2018-12-26', 0 ),
 (N'Stewart', N'Donovan', N'(931) 360-3205', '2019-10-16', '2020-11-12', '2021-01-07', 1 ),
 (N'Elaine', N'Cabrera', N'(483) 618-1218', '2018-08-18', '2018-08-18', '2019-01-17', 0 ),
 (N'Mechelle', N'Jacobson', N'(646) 319-7587', '2017-01-15', '2018-08-21', '2018-01-29', 0 ),
 (N'Lawrence', N'Hill', N'(467) 358-0901', '2016-12-24', '2017-05-22', '2017-09-23', 0 ),
 (N'Jolene', N'Hubbard', N'(326) 363-4952', '2018-09-15', '2020-08-28', '2020-07-11', 1 ),
 (N'Demetrius', N'Santos', N'(712) 546-2919', '2015-06-05', '2017-12-16', '2018-12-29', 1 ),
 (N'Declan', N'Sykes', N'(673) 825-6151', '2018-06-24', '2021-02-16', '2021-02-17', 0 ),
 (N'Winifred', N'Ward', N'(782) 825-4665', '2020-08-17', '2020-12-17', '2021-04-14', 0 ),
 (N'Pandora', N'Blair', N'(294) 397-5988', '2015-12-24', '2017-07-23', '2017-07-23', 0 ),
 (N'Yoshio', N'Chavez', N'(766) 998-3930', '2015-10-06', '2017-09-22', '2021-01-16', 1 ),
 (N'Kai', N'Lowery', N'(109) 202-5317', '2018-05-17', '2020-02-08', '2020-07-14', 0 ),
 (N'Carson', N'Mcpherson', N'(180) 367-9230', '2016-04-12', '2017-06-18', '2018-12-03', 0 ),
 (N'Howard', N'Beasley', N'(409) 372-4838', '2015-06-26', '2020-07-03', '2020-02-08', 0 ),
 (N'Neville', N'Montgomery', N'(774) 683-8433', '2017-04-29', '2019-12-29', '2018-05-18', 0 ),
 (N'Damon', N'Gregory', N'(849) 187-9684', '2015-07-02', '2017-10-24', '2018-05-18', 1 ),
 (N'Andrew', N'Oneil', N'(774) 281-2676', '2016-05-09', '2018-05-16', '2018-05-16', 0 ),
 (N'Yetta', N'Kane', N'(236) 515-7272', '2017-03-04', '2018-12-13', '2020-02-02', 0 ),
 (N'Debra', N'Roman', N'(655) 190-7658', '2016-04-12', '2018-12-30', '2019-01-04', 0 ),
 (N'Roary', N'Patterson', N'(795) 720-9509', '2017-12-23', '2019-05-20', '2019-06-11', 0 ),
 (N'Derek', N'Perry', N'(320) 361-3180', '2017-05-24', '2019-05-24', '2021-04-14', 0 ),
 (N'Tamara', N'Bray', N'(101) 223-3026', '2015-11-16', '2019-07-30', '2020-09-02', 0 ),
 (N'Deanna', N'Reyes', N'(560) 975-7894', '2016-02-05', '2017-08-17', '2019-06-11', 0 ),
 (N'Noah', N'Weber', N'(894) 970-5131', '2015-06-07', '2019-02-21', '2020-01-01', 0 );



   
MERGE [Library].[User] T
USING @UserStaging S ON S.PhoneNumber = T.PhoneNumber
WHEN MATCHED AND S.FirstName <> T.FirstName AND  S.LastName <> T.LastName THEN
   UPDATE
   SET FirstName = S.FirstName,
		LastName = S.LastName
WHEN NOT MATCHED THEN
   INSERT(FirstName,LastName,PhoneNumber,LastCheckOutDate,IsDeleted)
   VALUES(S.FirstName,S.LastName,S.PhoneNumber,S.LastCheckOutDate,S.IsDeleted);