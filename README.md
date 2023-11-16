
# store project 




.מערכת לניהול חנות
באמצעות המערכת ניתן לנהל מוצרים וכן עובדים ולקוחות.


## Entities



 - מוצר
 - לקוח
 - עובד



## Routes:


 1.  מוצר
 	
 - שליפת  רשימת מוצרים
	GET  https://api/product
 - שליפת מוצר לפי מזהה
	GET https://api/product/1
 - הוספת מוצר
	POST  https://api/product
 - עדכון מוצר
	PUT  https://api/product/1
 - מחיקת מוצר
	DELETE   https://api/product/1

 3.   לקוח

 - שליפת  רשימת לקוחות
	GET  https://api/customer
 - שליפת לקוח לפי מזהה
	GET https://api/customer/1
 - הוספת לקוח
	POST  https://api/customer
 - עדכון לקוח 
	PUT  https://api/customer/1
 - מחיקת לקוח 
	DELETE   https://api/customer/1
	
 3. עובד	
 - שליפת  רשימת עובדים
	GET  https://api/worker
 - שליפת עובד לפי מזהה
	GET https://api/worker/1
 - הוספת עובד
	POST  https://api/worker
 - עדכון עובד
	PUT  https://api/worker/1
 - מחיקת עובד
	DELETE   https://api/worker/1
