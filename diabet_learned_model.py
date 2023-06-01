# -*- coding: utf-8 -*-
"""
Created on Sun May 14 17:39:18 2023

@author: DMR
"""

'''
ÖĞRENMİŞ MODELİN BAŞKA PROJEYE LOAD EDİLMESİ

'''
import numpy as np
import pyodbc
import pickle as pkl

server = 'DESKTOP-S3S5IBG\SQLEXPRESS'
database = 'diabet_predict_KNN'
username = 'sa'
password = 's'


conn = pyodbc.connect('DRIVER={SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)

cursor = conn.cursor()
cursor.execute('SELECT * FROM data ORDER BY dataID DESC ')       # bu satır bize data tablosunu tersten getiriyor\ aslında kişinin ıd sine göre de getirme yapılabilirdi ama bizim butonumuz zaten son kişinin sonucunu getirecek ya o yüzden bu ko ziyadesi ile iş görecek
rows = cursor.fetchall()

veri = rows[0]                                                   # bu kod ise tersten gelen tablonun ilk satırını alıyor bu da demektir de aslında son eklenen kişileri getiriyor
            
                                                                 # bunu da değişkene atadık ki liste halinde gelsin ve istediğimiz verisine erişelim yani id kısımlarının çıkıp verilerin kalması gerekiyor ki predict kısmına dopru ekleme yapabilelim

knnModel= pkl.load(open("D:\KNN diabet hastalık tahmini\diabet_predict_KNN.pickle","rb"))

new_prediction=knnModel.predict(np.array([veri[2:]]))

print(new_prediction)


'''
bundan sonra yapman gereken tek bir şey kaldı

knn_model.predict([]) içerisinde gerekli değerleri gönderen SQL kodunu yazmak. daha sonrasında o tahminleme yapıp çıktıyı verecektir
'''
'''
sql deki result description için id ler şu şekilde 
1= HASTA
2=SAĞLIKLI
'''

sonuc_kayit=0                                          #bunu da artık sonucu sql e kaydetmek için bir değişkende tutmam gerekiyordu ondan yaptım. default olarak sağlıklı belirledim zaten aşağıdaki for da ne gelirse o olacak
if new_prediction[0]==1:
    sonuc_kayit=1
elif new_prediction[0]==0:
    sonuc_kayit=2

try:
    cursor2=conn.cursor()
    cursor2.execute(f"exec sonucEkle {veri[1]},{sonuc_kayit}")
    cursor2.commit() # yapılan ekleme işleminin veri tabanına kaydı için commit komutu gerekiyor
finally:
    conn.close()




#print(f"insert into result (personId,resultTypeId) values ({veri[1]},{sonuc_kayit})")














