mixed_data = {1,True,'Sen',32,2,2}
more_add = {'Senid',22}

# add() method -> add element to the set
mixed_data.add('Hello')
print(mixed_data)

# update() method
mixed_data.update(more_add)
print(mixed_data)

# discard() method -> remove Specific element
mixed_data.discard(True)
print(mixed_data)

# remove() method
mixed_data.remove('Hello')
print(mixed_data)