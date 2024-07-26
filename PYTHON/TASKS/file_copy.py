import os,filecmp
def CreateFile(file_name, old_file_name):
    
    if os.path.exists(file_name):
        print('File already exists')
        return
    
    
    else:
        file_create = open(file_name,'w')
        print('File created Sucessfully')

    
   
    old_file = open(old_file_name, 'r')
    contents = old_file.read()
    old_file.close() 
   
    new_file = open(file_name, 'w')
    new_file.write(contents)
    new_file.close() 
    print('file copied sucessfully')

    comparefiles(file_name,old_file_name)

def comparefiles(file_1,file_2):
    if(not os.path.exists(file_1)):
        print(file_1,'File Not Exists')
    elif(not os.path.exists(file_2)):
        print(file_2,"File Not Exists") 
    else:
        compare=filecmp.cmp(file_1,file_2)  
        if compare == True:
            print('Sucess-> the files are same ') 
        else :
            print('Failure -> the files are different')    
    


def main():
    print('Enter the file name you want to create:')
    file_name = input().strip()
    old_file_name = 'calci_dict.py'
    CreateFile(file_name, old_file_name)

   

    
if __name__ == "__main__":
    main()
