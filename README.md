# Description
A selenium based project providing e2e test scenarios for Google Gmail service. Could be employed to introduce BDD approach for application development. Built on .Net Core providing fast execution together with ability to be executed on major OS: MS Windows, Lunix, MacOS. 

It is implemented as a test task for SDET position.

# Technologies
* .Net Core 2.0
* Selenium
* SpecFlow
* NUnit

# Test execution
1. Update appsettings.json via valid Gmail account settings. Change “email” and “password” settings.
2. Run tests via NUnit runner.

# Key concepts
* **Page object modal pattern** enforces separation of element location code from test scenario flow. Page objects provide a single point of control over tested pages of application. No test scenario should interact with selenium elements. It should call methods from Page Object. Similarly Page Object classes should not perform any assertions or test scenario sequences. They are only adapters for the Web UI.
* **Gherkin code** to describe test scenario. It keeps implementation of particular step apart of scenario. This way improving its readability and make scenarios focused on business logic. Additional benefit is that non-IT persons can easily understand a scenario.
* **Test steps aggregation** into macro steps keeps scenarios focused. E.g. application sign-in step can contain several steps (like input login, password, press some buttons) in scenarios dedicated to logins form but should be single macro step in scenarios where only result is needed.
* **No hardcoded parameters** for test execution. All data that can parametrize test or particular scenario either should be stored in appsettings.json or passed via execution parameters argument. 

# Further improvements
* Automatically provisioning fixtures for test execution
* Introduce complex UI components wrappers to build page objects from larger blocks improving efficiency of adding new scenarios
* Test execution scripts and other user / developer friendly interface
* Integration with CI/CD pipelines / tools
* Full feature coverage via tests
* Building test run reports / statistics / analytics
* Organizing teamwork utilizing version control systems, packaging, publishing, etc.
* Documentation
