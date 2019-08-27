DROP TABLE DEPT CASCADE CONSTRAINTS;
DROP TABLE EMP CASCADE CONSTRAINTS;
CREATE TABLE DEPT (DEPTNO NUMBER(5) PRIMARY KEY, DNAME VARCHAR2(20));
CREATE TABLE EMP(EMPNO NUMBER(6) PRIMARY KEY, ENAME VARCHAR2(15),SALARIO NUMBER(10,2), deptno number(5) 
references DEPT);
INSERT INTO DEPT VALUES(1,'contabilidade');
INSERT INTO DEPT VALUES(2,'TI');
INSERT INTO DEPT VALUES(3,'VENDAS');
INSERT INTO EMP VALUES(100,'jose',2000,1);
INSERT INTO EMP VALUES(101,'julio',4000,1);
INSERT INTO EMP VALUES(102,'carlos',3000,2);
INSERT INTO EMP VALUES(103,'luiz',1200,2);
INSERT INTO EMP VALUES(104,'Maria',5000,2);
INSERT INTO EMP VALUES(105,'luzia',4500,3);

select min(salario) from EMP;

CREATE OR REPLACE PROCEDURE AtualizarSalario(vporcentagem IN NUMBER)
IS
    numero NUMBER(6);
    nome VARCHAR2(15);
    vsalario  NUMBER(10,2);
    
    CURSOR c_func IS
    SELECT e.EMPNO, e.ENAME, e.SALARIO
    FROM EMP e WHERE e.SALARIO = (SELECT MIN(e.SALARIO)
    FROM EMP e);
BEGIN
    OPEN c_func;
    LOOP
        FETCH c_func
        INTO numero, nome, vsalario;
        EXIT WHEN c_func%notfound;
        Dbms_Output.Put_Line( numero || '|' || nome || '|' || vsalario );
        UPDATE EMP e SET e.SALARIO = e.SALARIO + (e.SALARIO * vporcentagem) WHERE e.EMPNO = numero;
    END LOOP;
    CLOSE c_func;
END;
    

execute AtualizarSalario(20);
















create or replace procedure calcular(percento in number) is
    nome varchar2(15);
    numero number(6);
    salario number(10,2);
    
    cursor c is
    SELECT EMPNO,
        ENAME,
        SALARIO
    FROM
        EMP
    WHERE
        SALARIO = (
            SELECT
                MIN(SALARIO)
            FROM
                EMP
        );
begin
    open c;
    loop
        fetch c
        into nome, numero, salario;
        exit when c%notfound;
        DBMS_OUTPUT.PUT_LINE(numero || ' ' || nome || ' ' || salario);
        UPDATE EMP e SET e.SALARIO = e.SALARIO + (e.SALARIO * percento) WHERE e.EMPNO = numero;
    end loop;
    close c;
end;

set serveroutput on

execute calcular(10);