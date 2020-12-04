/* Complex DML queries*/
/* Type of SQL : MySQL  */


SELECT L1.INV_NUM, L1.LINE_NUM, P1.PROD_SKU, P1.PROD_DESCRIPT, L2.LINE_NUM, P2.PROD_SKU, P2.PROD_DESCRIPT, P1.BRAND_ID
FROM (LGLINE AS L1 JOIN LGPRODUCT AS P1 ON L1.PROD_SKU = P1.PROD_SKU) 
JOIN (LGLINE AS L2 JOIN LGPRODUCT AS P2 ON L2.PROD_SKU = P2.PROD_SKU)
ON L1.INV_NUM = L2.INV_NUM
WHERE P1.PROD_CATEGORY = 'Sealer' AND P2.PROD_CATEGORY = 'Top Coat' AND P1.BRAND_ID = P2.BRAND_ID
ORDER BY L1.INV_NUM, L1.LINE_NUM, L2.LINE_NUM DESC;

 
SELECT emp.emp_num, emp_fname, emp_lname, emp_email, total
FROM lgemployee emp JOIN
                (SELECT employee_id, Sum(line_qty) AS total
                 FROM lginvoice i join lgline l ON i.inv_num = l.inv_num join lgproduct p ON l.prod_sku = p.prod_sku join lgbrand b ON b.brand_id = p.brand_id
                 WHERE brand_name = 'BINDER PRIME' AND INV_DATE BETWEEN '2017-11-01' AND '2017-12-06'
                 GROUP BY employee_id) EMPSALES
      ON emp.emp_num = empsales.employee_id
WHERE total = (SELECT Max(total)
               FROM (SELECT employee_id, Sum(line_qty) AS total
                     FROM lginvoice i join lgline l ON i.inv_num = l.inv_num join lgproduct p ON l.prod_sku = p.prod_sku join lgbrand b ON b.brand_id = p.brand_id
                     WHERE brand_name = 'BINDER PRIME' AND INV_DATE BETWEEN '2017-11-01' AND '2017-12-06'
                     GROUP BY employee_id) AS EMPSALES2)
ORDER BY EMP_LNAME;


SELECT P.BRAND_ID, BRAND_NAME, BRAND_TYPE, Round(Avg(PROD_PRICE),2) AS AVGPRICE
FROM LGPRODUCT AS P JOIN LGBRAND AS B ON P.BRAND_ID = B.BRAND_ID
GROUP BY P.BRAND_ID, BRAND_NAME, BRAND_TYPE
HAVING Round(Avg(PROD_PRICE),2) = 
	(SELECT Max(AVGPRICE) AS "LARGEST AVERAGE"
                          FROM (SELECT BRAND_ID, 
					  Round(Avg(PROD_PRICE),2) AS AVGPRICE
                                FROM LGPRODUCT P
                                GROUP BY BRAND_ID) AS BRANDAVGS
		);


 
SELECT MANAGER.EMP_FNAME, MANAGER.EMP_LNAME, DEPT_NAME, DEPT_PHONE, E.EMP_FNAME, E.EMP_LNAME, CUST_FNAME, CUST_LNAME, INV_DATE, INV_TOTAL
FROM LGDEPARTMENT AS D JOIN LGEMPLOYEE AS E ON D.DEPT_NUM = E.DEPT_NUM JOIN LGEMPLOYEE AS MANAGER ON D.EMP_NUM = MANAGER.EMP_NUM
     JOIN LGINVOICE AS I ON E.EMP_NUM = I.EMPLOYEE_ID JOIN LGCUSTOMER AS C ON I.CUST_CODE = C.CUST_CODE
WHERE CUST_LNAME = 'HAGAN'
      AND INV_DATE = '2017-05-18'; 


 
SELECT E.EMP_NUM, EMP_LNAME, EMP_FNAME, SAL_AMOUNT
FROM LGEMPLOYEE AS E JOIN LGSALARY_HISTORY AS SH ON E.EMP_NUM = SH.EMP_NUM
WHERE SAL_END IS NULL
ORDER BY SAL_AMOUNT DESC;

 
SELECT E.EMP_NUM, EMP_LNAME, EMP_FNAME, SAL_AMOUNT
FROM LGEMPLOYEE AS E JOIN LGSALARY_HISTORY AS SH ON E.EMP_NUM = SH.EMP_NUM
WHERE SAL_FROM = (SELECT MIN(SAL_FROM) FROM LGSALARY_HISTORY WHERE EMP_NUM = E.EMP_NUM)
ORDER BY E.EMP_NUM;

 
SELECT L1.INV_NUM, L1.LINE_NUM, P1.PROD_SKU, P1.PROD_DESCRIPT, L2.LINE_NUM, P2.PROD_SKU, P2.PROD_DESCRIPT, P1.BRAND_ID
FROM (LGLINE AS L1 JOIN LGPRODUCT AS P1 ON L1.PROD_SKU = P1.PROD_SKU) 
JOIN (LGLINE AS L2 JOIN LGPRODUCT AS P2 ON L2.PROD_SKU = P2.PROD_SKU)
ON L1.INV_NUM = L2.INV_NUM
WHERE P1.PROD_CATEGORY = 'Sealer' AND P2.PROD_CATEGORY = 'Top Coat' AND P1.BRAND_ID = P2.BRAND_ID
ORDER BY L1.INV_NUM, L1.LINE_NUM, L2.LINE_NUM DESC;

 
SELECT emp.emp_num, emp_fname, emp_lname, emp_email, total
FROM lgemployee emp JOIN
                (SELECT employee_id, Sum(line_qty) AS total
                 FROM lginvoice i join lgline l ON i.inv_num = l.inv_num join lgproduct p ON l.prod_sku = p.prod_sku join lgbrand b ON b.brand_id = p.brand_id
                 WHERE brand_name = 'BINDER PRIME' AND INV_DATE BETWEEN '2017-11-01' AND '2017-12-06'
                 GROUP BY employee_id) EMPSALES
      ON emp.emp_num = empsales.employee_id
WHERE total = (SELECT Max(total)
               FROM (SELECT employee_id, Sum(line_qty) AS total
                     FROM lginvoice i join lgline l ON i.inv_num = l.inv_num join lgproduct p ON l.prod_sku = p.prod_sku join lgbrand b ON b.brand_id = p.brand_id
                     WHERE brand_name = 'BINDER PRIME' AND INV_DATE BETWEEN '2017-11-01' AND '2017-12-06'
                     GROUP BY employee_id) AS EMPSALES2)
ORDER BY EMP_LNAME;

 
SELECT C.CUST_CODE, CUST_FNAME, CUST_LNAME 
FROM LGCUSTOMER C JOIN LGINVOICE I ON C.CUST_CODE = I.CUST_CODE 
WHERE EMPLOYEE_ID = 83649 AND C.CUST_CODE IN (SELECT CUST_CODE FROM LGINVOICE WHERE EMPLOYEE_ID = 83677)
ORDER BY CUST_LNAME, CUST_FNAME;


SELECT c.cust_code, cust_fname, cust_lname, cust_street, cust_city, cust_state, cust_zip, inv_date, inv_total AS "Largest Invoice"
FROM lgcustomer c join lginvoice i ON c.cust_code = i.cust_code
WHERE cust_state = 'AL' AND inv_total = (SELECT Max(inv_total) FROM lginvoice i2 WHERE i2.cust_code = c.cust_code)
UNION
SELECT cust_code, cust_fname, cust_lname, cust_street, cust_city, cust_state, cust_zip, NULL, 0
FROM lgcustomer
WHERE cust_state = 'AL' AND cust_code NOT IN (SELECT cust_code FROM lginvoice)
ORDER BY cust_lname, cust_fname;

 
SELECT brand_name, brand_type, Round(avgprice,2) AS "Average Price", USOLD AS "Units Sold"
FROM lgbrand b join (SELECT brand_id, Avg(prod_price) AS avgprice FROM lgproduct GROUP BY brand_id) sub1 ON b.brand_id = sub1.brand_id
     join (SELECT brand_id, Sum(line_qty) AS USOLD FROM lgproduct p join lgline l ON p.prod_sku = l.prod_sku GROUP BY brand_id) sub2
     ON b.brand_id = sub2.brand_id
ORDER BY brand_name;

 
SELECT brand_name, brand_type, prod_sku, prod_descript, prod_price
FROM lgproduct p join lgbrand b ON p.brand_id = b.brand_id
WHERE brand_type <> 'PREMIUM'
      AND prod_price > (SELECT Max(prod_price) FROM lgproduct p join lgbrand b ON p.brand_id = b.brand_id WHERE brand_type = 'PREMIUM');
