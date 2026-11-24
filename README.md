[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/bc02b800747240f9b2aa3bd579ecc8b6)](https://app.codacy.com/gh/panoramicdata/AutoTask.Psa.Api/dashboard)

# AutoTask.Psa.Api

> **Need help with APIs or .NET?** Panoramic Data are experts in APIs and .NET, and we can help with your development. [Contact us](https://www.panoramicdata.com/contact-us) or see our [software services](https://www.panoramicdata.com/services/software).

Datto Autotask PSA REST API

Supports .NET 11.0.

[![Nuget](https://img.shields.io/nuget/v/AutoTask.Psa.Api)](https://www.nuget.org/packages/AutoTask.Psa.Api/)

## Breaking changes

- Properties previously declared with private setters (for example all of `ThresholdStatusResultModel`, `IsTaskAttachment` and `ParentType` on attachment models, `ParameterExpression.CanReduce` and `SoapParentPropertyId`) now have public setters and are populated from API responses. Previously they were always null. Code that relied on them being null will now see real values.
