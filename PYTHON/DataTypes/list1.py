#Creating a list :
#Creating same data type/HOMOGENIUS

course = ['python','java','PHP'] # string 
rollno = [123,345,456] # integer


#Creating mixed type/HETEROGENOUS
mixed_type = [123,'java',True,99.0]
print('HETEROGENOUS',mixed_type)
print('Length:',len(mixed_type))


print('ACCESS value of 123:',mixed_type[0])

print('ACCESS value of java:',mixed_type[1])

print('ACCESS value of True:',mixed_type[2])

print('ACCESS value of 99.0:',mixed_type[3])



print("accessing the values; ", mixed_type[-1])
print("accessing the values; ", mixed_type[-2])
print("accessing the values; ", mixed_type[-3])


#SLICING
mixed_type=['Boga',44,55,'senidgood']
print("slicing positive",mixed_type[1:3])
print("slicing negative",mixed_type[-4:-1])

#MUTABLE (can change,add,and delete)

fruits =['Mango','Banana','Grapes','Watermelon']
fruits[2]='Kiwi'
print('Using index Grapes replaced by kiwi',fruits)

del fruits[3]
print('removing watermelon ',fruits)

#Using SLICING replace 
fruits[1:3] = ['drangon_fruits','apple']
print('removing Using SLICING ',fruits)
