# Proje-1 Insertion Sort
A-) [22,27,16,2,18,6] -> Insertion Sort

    1) Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
    2) Big-O gösterimini yazınız.
    3) Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması,
    Best case:Aradığımız sayının dizinin en başında olması.
    4) Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.


B-) [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

CEVAPLAR:

A-)
    1) 	 [22,27,16,2,18,6]   
         [2,27,16,22,18,6] 
	     [2,6,16,22,18,27] 
	     [2,6,16,18,22,27] 

    2)   n+(n-1)+(n-2)+1/2 = n.(n+1)/2 = (n^2+n)/2
         = O(n^2)   

    3)   Average case: aranan sayı 3. ve 4. eleman yani 16, 18'dir.
         Worst case: aranan sayı 6. eleman yani 27'dir.
         Best case: aranan sayı 1. eleman yani 2'dir.

    4)   dizi sıralandıktan sonra 18 sayısı Average case kapsamına girer.


B-)     [7,3,5,8,2,9,4,15,6]

        [2,3,5,8,7,9,4,15,6]
        [2,3,4,8,7,9,5,15,6]
        [2,3,4,5,7,9,8,15,6]
        [2,3,4,5,6,9,8,15,7]
        
    
