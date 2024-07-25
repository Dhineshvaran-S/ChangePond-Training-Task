# #course = ['','python','java', ';$','angu;lar','php']


# course = ['','python','java', ';$','angu;lar','php']
# filtered_course = list(filter(lambda COUR: COUR != len(COUR)>1 and , course))
# print(filtered_course)





def main():
    splChar = set('!@#$%^&*()-_/?,<>.:;\'\"+=[]{}')
    course = ['', 'Python', 'java', ',,', 'angul:ar', 'php']
    
    filter_list = list(filter(lambda x: x != '' and all(char not in splChar for char in x), course))
    print('Filter List : ', filter_list)

if __name__ == '__main__':
    main()

product_id = ['HEM-234','HEM-123','HEM-566']
#[234,123,566]
filter_product=list(map(lambda x: (x.split('-')[1]),product_id))
product_id = ['HEM-234', 'HEM-123', 'HEM-566']
print('output',filter_product)

dict_details= [
    {'name': 'shreya', 'age': 15},
    {'name': 'pratiksha', 'age': 13},
    {'name': 'prerna', 'age': 15}
]


sorted_list= sorted(dict_details, key=lambda x: x['age'])

print(sorted_list)


dict_details= [
    {'name': 'shreya', 'age': 15},
    {'name': 'pratiksha', 'age': 13},
    {'name': 'prerna', 'age': 15}
]


sorted_list= sorted(dict_details, key=lambda x: x['name'])

print(sorted_list)
