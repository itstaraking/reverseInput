# give instruction and get user input
input = input("Enter a sentence and I will reverse it: ")

# split input
tokens = input.split(" ")

# for loop to manipulate string
for words in tokens:
    words = tokens[::-1]

# display the new string
print(words)

