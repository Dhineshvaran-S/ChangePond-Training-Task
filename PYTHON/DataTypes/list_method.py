# menu_card=['Panneer','Dal','rice']
# print('Available Items in menu card:',menu_card)

# #append()--> Adds an element at the end of the list
# menu_card.append('Kofta')
# print('After using append method :',menu_card)
# #'Dal Tadka','Biriryani'
# #extend() --> Add the elements of a list(or iteratable)
# # to the end of list 
# menu_card.extend(['Dal Tadka','Biriyani'])
# print('Using Extend Method :',menu_card)

# #insert --> Adds an element at the specified position 
# menu_card.insert(1,'VegBiriyani')
# print("Using Insert menthod: ",menu_card)

# #remove() method -> will remove specified element 

# menu_card.remove('Dal Tadka')
# print('Using Remove method:',menu_card)

# #pop() method -> Removes elements of specified position 
# menu_card.pop(2)
# print('Using POP method: ',menu_card)

menu_card= ['Panner','Dal','Rice']
#index method 
index_method = menu_card.index('Rice')
print('It will give the position : ',index_method)

index_method = menu_card.index('Panner')
print('It will give the position : ',index_method)

#sort method 

menu_card.sort()
print('Using Sort method :',menu_card)