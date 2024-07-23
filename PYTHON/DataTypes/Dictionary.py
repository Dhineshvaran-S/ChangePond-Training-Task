watch_details ={
    'Titan':8000,
    'Fastrack':5000,
    'Omega':9000,
    'Titan':12000
}


print('watch Available',watch_details)  #Titan(considered the latest key )
print(len(watch_details),)

print(type(watch_details))


print('Using Key', watch_details['Titan'])


watch_details ={
    'Titan':8000,
    'Fastrack':5000,
    'Omega':9000,
    'Cartier':8000
}

print('watch Available',watch_details)  #Titan(considered the latest key )
print(len(watch_details),)

print(type(watch_details))


print('Using Key', watch_details['Cartier'])



watch_details ={
    'Titan':8000,
    'Fastrack':5000,
    'Omega':9000,
    'Cartier':8000
}
print(watch_details)
print(len(watch_details))
print(type(watch_details))
print('Using key ',watch_details['Titan'])
watch_details['omega']=5000
print('After modifying',watch_details)
watch_details['imt']=9000
print('Adding new watch',watch_details)

# Create a dictionary of food items and price (add,modify)

Food_cort={
    'Samsa':10  ,
    'Bajji':10  ,
    'Bonda':15  
}
print(Food_cort)
print(len(Food_cort))
Food_cort['Addon Chutney']=5
print('Aftert adding',Food_cort)
Food_cort['Samsa']=15  
print('After Modifying',Food_cort)

#Nested Dictionary 
users ={
    'kalkinovel':{
        'first_name':'Kalki',
        'last_name':'Chapter 1',
        'Location':'Sozhai'
    },

    'Shaulin':{
        'first_name':'shero',
        'last_name':'Chapter 2',
        'Location':'Nani'


    },
     'Sherin':{
        'first_name':'Pero',
        'last_name':'Chapter 3',
        'Location':'Chennai'

    
},
}

for bookname, user_info in users.items():
    print(f"bookname: {bookname}")
    print(f"First Name: {user_info['first_name']}")
    print(f"Last Name: {user_info['last_name']}")
    print(f"Location: {user_info['Location']}")
    print()

    print(f"Location: {user_info['Location']}")
    print()

    print(f"First Name: {user_info['first_name']}")
    print()

