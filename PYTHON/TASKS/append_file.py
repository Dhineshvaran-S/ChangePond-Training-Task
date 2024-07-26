import os 
def append_content_file(name,added):
    if(os.path.exists(name)):
        write_app=open(name,'a')
        write_app.write(added)
        print("contents are written")
    else:
        print("file does not exist")


def main():
    to_append=input("enter the contents to append: ")
    app_file=input("enter the filename to which u need to append: ")
    append_content_file(app_file,to_append)

if __name__ =="__main__":
    main()