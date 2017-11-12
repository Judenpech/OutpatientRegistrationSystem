/*
门诊挂号系统数据库操作
*/
USE OPRSBase;

----查询所有病人信息；
SELECT * 
FROM dbo.tb_patient;

----根据病人身份证号查询；
SELECT *
FROM dbo.tb_patient
WHERE id='365745199711126376';

----根据病人编号查询；
SELECT *
FROM dbo.tb_patient
WHERE visitNo='20171112001';

----插入管理员；
INSERT tb_operator
    (No,Name,Password)
    VALUES('1','test',HASHBYTES('SHA','1'));

----添加病人；
INSERT dbo.tb_patient
        ( No ,
          Name ,
          age ,
          sex ,
          birthday ,
          nationality ,
          nation ,
          email ,
          tel ,
          Address ,
          firstMan1 ,
          firstManTel1 ,
          firstMan2 ,
          firstManTel2 ,
          id ,
          visitNo ,
          regDate ,
          allergyHistory ,
          operationHistory
        )
VALUES  ( '' , -- No - char(15)
          '' , -- Name - varchar(25)
          0 , -- age - int
          NULL , -- sex - bit
          '2017-11-12 14:29:50' , -- birthday - date
          '' , -- nationality - varchar(25)
          '' , -- nation - varchar(15)
          '' , -- email - char(45)
          '' , -- tel - char(15)
          '' , -- Address - varchar(45)
          '' , -- firstMan1 - varchar(25)
          '' , -- firstManTel1 - char(15)
          '' , -- firstMan2 - varchar(25)
          '' , -- firstManTel2 - char(15)
          '' , -- id - char(18)
          '' , -- visitNo - char(15)
          '2017-11-12 14:29:50' , -- regDate - date
          '' , -- allergyHistory - varchar(255)
          ''  -- operationHistory - varchar(255)
        )

----修改病人;
UPDATE dbo.tb_patient
    SET Name='123',
        age=0,
        sex=0,
        birthday='2017-11-11 14:50:07',
        nationality='',
        nation='',
        email='',
        tel='123',
        Address='',
        firstMan1='',
        firstManTel1='',
        firstMan2='',
        firstManTel2='',
        id='',
        visitNo='',
        regDate='2017-11-11 14:50:07',
        allergyHistory='',
        operationHistory=''
    WHERE No='20171112104748';
        