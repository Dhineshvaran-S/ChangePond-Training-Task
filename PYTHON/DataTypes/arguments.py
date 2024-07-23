#Area of Circle = PI*Radius*Radius 
def Area(Radius,PI=3.14):
    print('Radius:',Radius)
    print('pi value:',PI)

    Result = PI*Radius*Radius
    return Result

def main():
    #Positional Argument 
    Output_1= Area(10,12)
    print('Area of Circle:',Output_1)
    #first argument is positional and second is default 
    Output_1=Area(20)
    print('Area of Circle:',Output_1)

    
    # Keyword Argument
    output_1 = Area(Radius=10)
    print(output_1)

if __name__ =="__m  ain__":
        main()
