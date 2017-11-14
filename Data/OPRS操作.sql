/*
门诊挂号系统数据库操作
*/
USE OPRSBase;

----查询所有病人信息；
SELECT * 
FROM dbo.tb_patient;

----根据病人姓名查询；
SELECT *
FROM dbo.tb_patient
WHERE Name='张三';

----根据病人身份证号查询；
SELECT *
FROM dbo.tb_patient
WHERE id='365745199711126376';

----根据病人编号查询；
SELECT *
FROM dbo.tb_patient
WHERE No='20171112030327';

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
          '2017-11-13 02:51:47' , -- birthday - date
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
          '2017-11-13 02:51:47' , -- regDate - date
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
    
----添加预约;
INSERT dbo.tb_registration
        ( patientNo ,
          deptNo ,
          docNo ,
          regDate ,
          regTime ,
          operater
        )
SELECT '20171112102319',d2.NO,d1.No,'2017-11-12 02:23:19','2017-11-12 02:23:19','3150707012'
FROM dbo.tb_doctor d1,dbo.tb_dept d2
WHERE d1.NAME='邹良能' AND d2.NAME='内科';

----查询所有预约；
SELECT *
FROM dbo.tb_registration;

----显示预约;
SELECT r.NO 预约号,r.patientNo 患者编号,p.Name 患者姓名,d1.NAME 预约科室,d2.NAME 预约医生, r.regDate 预约日期,r.regTime 预约时间
FROM dbo.tb_registration r,dbo.tb_patient p, dbo.tb_dept d1, dbo.tb_doctor d2
WHERE r.docNo=d2.No AND r.deptNo=d1.NO AND r.patientNo=p.No AND r.regDate='2017-11-12'
ORDER BY r.NO,r.regDate,r.regTime;

----根据医生查询科室；
SELECT d1.name FROM tb_dept d1,tb_doctor d2 WHERE d2.NAME='邹良能' AND d2.deptNo=d1.NO;

----查询所有科室；
SELECT NO 科室编号,NAME 科室名称,DSCP 科室描述
FROM dbo.tb_dept;

----删除指定科室; --外键约束？
DELETE FROM dbo.tb_dept
WHERE NAME='测试科';

----增加科室；
INSERT dbo.tb_dept
        ( NAME,DSCP )
VALUES  ( '新增科室','描述' );

----更新科室；
UPDATE dbo.tb_dept 
SET NAME='更新科室',dscp='更新科室描述'
WHERE NO=16;

----查询号别；
SELECT id 编号,NAME 挂号名称,price 价格
FROM dbo.tb_regType;

----删除号别；
DELETE FROM dbo.tb_regType
WHERE id=3;

----增加号别；
INSERT dbo.tb_regType
        ( NAME, price )
VALUES  ( 'test', -- NAME - char(45)
          100  -- price - money
          );
----修改号别；
UPDATE dbo.tb_regType
SET NAME='修改测试',price=100
WHERE id=4;