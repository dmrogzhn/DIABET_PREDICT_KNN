# -*- coding: utf-8 -*-
"""
Created on Fri May 12 14:13:53 2023

@author: DMR
"""
#BU DOSYA MODELİN ÖĞRENDİKTEN SONRA BAŞKA DOSYALARDA KULLANILABİLİR HALE GETİRİLDİĞİ DOSYADIR

import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
from sklearn.preprocessing import MinMaxScaler

data = pd.read_csv("diabets.csv")
data.head()

y=data.Outcome.values # burada outcome yani sanouçları direkt y ye atadık
x = MinMaxScaler()
x_ham_veri= data.drop(["Outcome"],axis=1) # outcome sütununu alma dedik ki sonuçları çıkarsın ham değerleri alsın
scaled_data=x.fit_transform(x_ham_veri) # burada veriyi normalize ettik 0-1 aralığına getirdik. bunu da top değeri 1 min değeri 0 aldık ve diğer değerleri de buna göre oranladık



# train datamız ile test datamızı ayırıyoruz
# train datamız sistemin sağlıklı insan ile hasta insanı ayırt etmesini öğrenmek için kullanılacak
# test datamız ise bakalım makine öğrenme modelimiz doğru bir şekilde hasta ve sağlıklı insanları ayırt edebiliyor mu diye 
# test etmek için kullanılacak...




x_train,x_test,y_train,y_test= train_test_split(scaled_data,y,test_size=0.1,random_state=15)#burada daha sonra test kısmını ne kadar almalı denemesini de yapacağız yani ne kadar test kısmı ayırırsak daha doğru değerler alıyoruz buna for döngüleri ile bakmayı deneyeceğiz

# şimdi KNN modelimizi oluşturuyoruz

knn=KNeighborsClassifier(n_neighbors=5) # en yakın 3 komşuya göre hareket et dedik ayrıca bunları da for döngüleri ile deneyerek en optimum olanını bulmaya çalışacağız
knn.fit(x_train, y_train) # modelimize değerler ile sonuçları göndererek öğrenmesini .fit ile sağladık

#şimdi deneyeceğiz

prediction = knn.predict(x.transform(x_test))
print("K=3 için Test verilerimizin doğrulama testi sonucu ", knn.score(x_test, y_test))

# MODELİN KAYIT EDİLDİĞİ KISIM

import pickle # pickle uzantısı ile artık modelimizi kaydedip load edilebilir hale getireceğiz

model_dosyasi= "diabet_predict_KNN.pickle"
pickle.dump(knn, open(model_dosyasi,"wb")) # burada "wb": open fr writing and open in bşnary mode anlamına geliyor yani şimdi bu modeli artık bir dosyaya kaydedip yazacak. bu dosya kodumuzun bulunduğu dosya olacak

# artık modelimiz "diabet_predict_KNN" adıyla pickle uzantılı bir model haline gelmiş oldu
'''
bundan sonra yeniden bir çok kodu yazmak yerine bu modelin kullanılacağı her kodda import pickle dedikten sonra dosya yolunu belirterek kullanmak yeterli olacaktır
yani artık tek satırla öğrenmiş modelimizi kullanabiliriz demektir
bundan sonra yapılacak tek bir işlem kalıyor o da SQL in kullanıldığı python kodunu yazıp modelimize uygun şekilde tahminleme verisi olarak vermek
'''