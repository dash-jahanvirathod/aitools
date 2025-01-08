string = "madam"
print(reverse_string(string))  # Output: madam

/write code for a function that takes a string as input and returns the string with all vowels removed

string = "hello world"
print(remove_vowels(string))  # Output: hll wrld

//write code for a function that takes a string as input and returns the string with all spaces removed

string = "hello world"
print(remove_spaces(string))  # Output: helloworld

//write me a function for password validation

def validate_password(password):
    if len(password) < 8:
        return False
    if not any(char.isupper() for char in password):
        return False
    if not any(char.islower() for char in password):
        return False
    if not any(char.isdigit() for char in password):
        return False
    return True
