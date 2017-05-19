# DFE Edubase2 .Net SOAP client
|               |               |
| ------------- | ------------- |
|![crest](https://assets.publishing.service.gov.uk/static/images/govuk-crest-bb9e22aff7881b895c2ceb41d9340804451c474b883f09fe1b4026e76456f44b.png) ||
| Build | [![Build status](https://ci.appveyor.com/api/projects/status/gy7hal7n0s8w07d2?svg=true)](https://ci.appveyor.com/project/scottcowan/ukrlp-soap-client) |
| .Net Client |[![](https://img.shields.io/nuget/v/DFE.Edubase2.SoapAPI.Client.svg)](https://www.nuget.org/packages/DFE.Edubase2.SoapAPI.Client/)| 

## An API client for [Edubase2](http://www.education.gov.uk/edubase/home.xhtml)

The Department for Education's register of educational establishments in England and Wales. 



## Usage

### Authentication

You will need to register an account with the DFE, follow the instructions [here](http://www.education.gov.uk/edubase/feedback.xhtml)

### Find all the HEI establishments

```c#
var client = new EstablishmentClient("username", "password");
var results =
    client.FindEstablishments(new EstablishmentFilter
    {
        TypeOfEstablishment = EstablishmentType.HigherEducationInstitutions,
        Fields = new StringList {"UKPRN"}
    });
```

### Find all the establishments
```c#
var client = new EstablishmentClient("username", "password");
var results = client.FindEstablishments();
```