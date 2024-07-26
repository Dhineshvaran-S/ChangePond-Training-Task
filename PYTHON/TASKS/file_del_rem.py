import os

def remove_file(file_name):
    
    if os.path.exists(file_name):
        os.remove(file_name)
        print(f"File '{file_name}' has been deleted successfully.")
    else:
        print(f"File '{file_name}' does not exist.")

def main():
    file_name = input("Enter the File name:")
    remove_file(file_name)

if __name__ == "__main__":
    main()