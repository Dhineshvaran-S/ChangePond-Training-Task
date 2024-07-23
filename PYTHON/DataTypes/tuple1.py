#Create a tuple 
# Homogenus 
student_id = (123,124,125,126)
ice_cream =('Vannila','Choco','BlueBerry')

#Heterogenus 
mixed_type = (123,'Hello',False,56.78)
#len()
#using index ==> Blueberry(Posititve index )
#using index ==> False(Negative index)
#using slicing ==> 'Hello' ,False 


print("length of student id ",len(student_id))
print("length of student id ",ice_cream[2])
print("length of student id ",mixed_type[-2])
print("length of student id ",mixed_type[1:3])



ice_cream=('Vannila') #str 
print(ice_cream,type(ice_cream))
ice_cream=('Vannila',) #comma (tuple)
print(ice_cream,type(ice_cream))

# #immutable (cannot modify, delete or add)
# mixed_tube[0]=True 
# print(mixed_type)

ice_cream=('Vannila','Choco-chips','Blueberry','Vannila')
countmethod=ice_cream.count('Vannila')
print('Count method:',countmethod)
print()
indexmethod=ice_cream.index('Vannila')
print('Index method:',indexmethod)

