# FakeItGen Library
Generates identity by scraping data from fake-it.ws.

## Features
- No API key needed, no more $5/day.
- Up to 70 countries are supported.
- Generates [realistic identities.](#how-realistic-are-the-identities)
- Easy library integration.

## Dependencies
- [HtmlAgilityPack](https://html-agility-pack.net/)

## Supported Data:
These are the data that you can generate by this library.
- Country
- Name
- Age
- City
- Gender
- Postcode
- Date of Birth
- Phone
- Mother's Maiden Name (MMN)
- Height
- Weight
- Hair Color
- Eye Color
- Email
- Ethnicity
- Zodiac Sign
- Credit Card Type (CCType)
- Credit Card Number (CCNum)
- Credit Card CVV2 (CCPin)
- Credit Card Expiry (CCExp)
- Qualification
- Institution
- Company Name
- Salary
- Company Address
- Company Phone
- Job Title
- Company Email

## Unsupported Data
These data aren't supported yet. They will be added in the future versions of this library.
- Username
- Password
- IPV4 Address
- IPV6 Address
- Useragent
- Vechicle
- License Plate
- VIN
- Color

## How to use
1. Download [HtmlAgilityPack](https://html-agility-pack.net/) from Nuget.
2. Add ``using FakeGenerator;`` to your code.
3. Add object to your specified class.

Example:
```c#
FakeGenBeta identity = new FakeGenBeta();
identity.Generate("USA");
```
## Generating Data:
Print the generated name

``Console.WriteLine(fakeBeta.name);``

Print the generated DOB

``Console.WriteLine(fakeBeta.dateOfBirth);``

## Other Information:
### How Realistic are the Identities?
- We use real cities and matching zip codes in each city and state.
- Area codes and social security numbers match the address location
- Height and weight are realistic and computed based on a normal distribution of heights and BMI for the selected gender
- Names are determined based on the frequency of different names in the year of birth
- We put lots of effort in our work to ensure identities are realistic
- We continuously improve our services working to provide the best service

[More Information](https://fake-it.ws/about/)

### About this library
If you have any questions, Please hit me up on Discord: Archclx#6871
