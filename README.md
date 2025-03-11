# QA Automation Framework

## Prerequisites
- Visual Studio 2022
- .NET Core SDK 8.0
- Chrome browser
- reqnroll
- allure

## How to Run the Tests
1. Clone the repository: git clone https://github.com/rakhipal/NorthStandardProject.git
2. Navigate to the project directory: cd NorthStandardProject
3. Install dependencies: dotnet restore
4. Run the tests: dotnet test

## WebDriver Management
This project uses `WebDriverManager` to automatically download and configure the correct ChromeDriver version.

## Test Execution
To execute the tests, use the following command: dotnet test
To generate allure report, use the following command: allure serve bin\Debug\net5.0\allure-results

## Contributing
Contributions are welcome! Please follow these steps to contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes and commit them (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a pull request.

## Repository
- **GitHub Repo:** https://github.com/rakhipal/NorthStandardProject.git
