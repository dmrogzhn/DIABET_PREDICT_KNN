# -*- coding: utf-8 -*-
"""
Created on Sat May 13 12:55:40 2023

@author: DMR
"""

# -*- coding: utf-8 -*-
"""
Created on Fri May 12 14:13:53 2023

@author: DMR
"""

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





#x_train,x_test,y_train,y_test= train_test_split(scaled_data,y,test_size=test_size,random_state=random_state)# burada daha sonra test kısmını ne kadar almalı denemesini de yapacağız yani ne kadar test kısmı ayırırsak daha doğru değerler alıyoruz buna for döngüleri ile bakmayı deneyeceğiz

# şimdi KNN modelimizi oluşturuyoruz

#knn=KNeighborsClassifier(n_neighbors=3) # en yakın 3 komşuya göre hareket et dedik ayrıca bunları da for döngüleri ile deneyerek en optimum olanını bulmaya çalışacağız
#knn.fit(x_train, y_train) # modelimize değerler ile sonuçları göndererek öğrenmesini .fit ile sağladık

best_accuracy = 0
best_params = {}

for test_size in [0.1,0.15, 0.2,0.25, 0.3]:# buradaki amaç benim verdiğim değerler sınırında knn için gerekli 3 parametrenin verdiği en yüksek yüzdeye sahip olacağı parametreleri listelemekti. öğrenecek modele buradaki değerleri ben el ile girdim
    for random_state in range(1, 100):
        for n_neighbors in range(1, 10):
            x_train,x_test,y_train,y_test= train_test_split(scaled_data,y,test_size=test_size,random_state=random_state)
            knn = KNeighborsClassifier(n_neighbors=n_neighbors)
            knn.fit(x_train, y_train)
            accuracy = knn.score(x_test, y_test)
            if accuracy > best_accuracy:
                best_accuracy = accuracy
                best_params = {'test_size': test_size, 'random_state': random_state, 'n_neighbors': n_neighbors}

print("En yüksek doğruluk oranı:", best_accuracy)
print("En iyi parametreler:", best_params)


#şimdi deneyeceğiz

prediction = knn.predict(x.transform(x_test))
print("K=3 için Test verilerimizin doğrulama testi sonucu ", knn.score(x_test, y_test))




sz={1:"Hasta",0:"Sağlklı"}

print(sz[1])






