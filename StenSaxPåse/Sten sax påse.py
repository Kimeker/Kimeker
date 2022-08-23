import random
choice = ""
player = input("Välj 'r' för sten, 's' för sax och 'p' för papper.")
computer = random.choice(['r', 's', 'p'])

if player == computer:
    print("Det blev lika!")
if player == 'r' and computer == 's':
    print("Du vann!")
elif player == 's' and computer == 'p':
    print("Du vann!")
elif player == 'p' and computer == 's':
    print("Du vann!")
elif computer == 'r' and player == 's':
    print("Du förlorade!")
elif computer == 's' and player == 'p':
    print("Du förlorade!")
elif computer == 'p' and player == 's':
    print("Du förlorade!")

print("Datorn valde: " + computer)

