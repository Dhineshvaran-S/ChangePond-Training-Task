# def Addition():
#     print('Addition')
# Addition()

# def Addition(value_01):
#     print('inside Additon')
#     print('Argument:',value_01)

# Addition(10)

# def Addition(value_01,value_02):
#     print('inside Additon')
#     print('Argument 1:',value_01)
#     print('Argument 2:',value_02)
#     print(f'{value_01} and {value_02} addition is :',value_01 + value_02)
# Addition(10,20)


# def Addition(value_01,value_02):
#     print('inside Additon')
#     print('Argument 1:',value_01)
#     print('Argument 2:',value_02)
#     Add =value_01+value_02
#     return Add
#     print(f'{value_01} and {value_02} addition is :',value_01 + value_02)
# Result = Addition(10,20)
# print('Adddtion of nos is ',Result)


def Addition(value_01,value_02):
    print('inside Additon')
    print('Argument 1:',value_01)
    print('Argument 2:',value_02)
    Add =value_01+value_02
    Sub=value_02-value_01
    return Add,Sub
    
    print(f'{value_01} and {value_02} addition is :',value_01 + value_02)
add,sub = Addition(10,20)
print('Adddtion of nos is ',add)
print('Subraction of nos is ',sub)
print()
def Addition(value_01,value_02):
    print('inside Additon')
    print('Argument 1:',value_01)
    print('Argument 2:',value_02)
    Add =value_01+value_02
    Sub=value_02-value_01
    return Add,Sub
    
    print(f'{value_01} and {value_02} addition is :',value_01 + value_02)
add= Addition(10,20)
print('Adddtion of nos is ',add[0])
print('Subraction of nos is ',add[1])
