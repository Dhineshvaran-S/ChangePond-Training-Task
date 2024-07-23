country =['india','america','japan','iran','turkey','iraq']

print(country[1])


for name in country :
    print(f'{name.title()}, these are the list of countries')

author_name=('j k rowling','rachel aaron','hans aanrud','verna aardama')

for name in author_name:

  print(f'{name.title()}')

# for auth_name in author_name
#   print(auth_name)

for i in range(5):
    print(i)
    print()
for i in range(2,11):
    print(i)
    print()
for i in range(2,11,2):
    print(i)
    print()
# START =2 STOP =10    OUTPUT 
2
4
6
8
10
  

for i in range (2,int(11/2),2): #5.5
    print(i)
    
print()
    #OUTPUT  2
4
6
8
10
2
4

author_name=('j k rowling','rachel aaron','hans aanrud','verna aardama')


for auth_name in range(len(author_name)): 

  print(auth_name)


print()


for auth_name in range(len(author_name)): 
    print(author_name[auth_name],'---',auth_name)


# iterate over a string using for loop 

time_update = "it's 4.15pm"

for time in range(0,len(time_update)) :
    print(time_update[time])