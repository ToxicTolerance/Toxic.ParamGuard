<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
<!--[![LinkedIn][linkedin-shield]][linkedin-url]-->



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/ToxicTolerance/Toxic.ParamGuard">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">ParamGuard</h3>

  <p align="center">
    A small library for lazychaining GuardClauses. Nothing really special.
  
  </p>
</div>



<br>

<!-- ABOUT THE PROJECT -->
## About The Project

<!-- [![Product Name Screen Shot][product-screenshot]](https://example.com) -->

ParamGuard exposes a simple and extensible API for lazy chaining multiple GuardClauses. You can extend ParamGuards API by defining GuardClauses as ExtensionMethods.
<br>
I used this projects to fiddle around a bit with Fluent API´s in C#. Also check out [Ardalis GuardClauses](https://github.com/ardalis/GuardClauses) which gave me the inspiration to try something like this myself.

<!-- GETTING STARTED -->
## Getting Started

 ```csharp
     public void RegisterPerson(Person item)
        {
            /*Option 1*/
            Guard.ThrowOn(item).IfNull();

            // Further processing here

        }

        public void RegisterPerson(Person item)
        {
            /*Option 2*/
            item.Throw().IfNull();

            // Further processing here

        }
```


```csharp
      public class Person
        {
            private string _name;
            private string _lastName;
            private DateTime _birthDate;


            public Person(string name, string lastName)
            {
                _name = Guard.ThrowOn(name).IfNullOrWhiteSpace().Value;
                _lastName = Guard.ThrowOn(_lastName).IfNullOrWhiteSpace().Value;
            }

            public Person(string name, string lastName, DateTime birthDate)
            {
                _name = name.Throw().IfNullOrWhiteSpace().Value;
                _lastName = lastName.Throw().IfNullOrWhiteSpace().Value;
                _birthDate = birthDate.Throw().IfNull().Value;
            }
        }
```

<!-- USAGE EXAMPLES -->
## Create your own GuardClause

```csharp
        public static IValueGuardParameter<T> IfNull<T>(this IGuardParameter<T> param, string message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
            IValueGuardParameter<T> parameter = param as IValueGuardParameter<T>;

            if (parameter.Value == null)
                if (message == null)
                    throw new ArgumentNullException(parameter.ParameterName);
                else
                    throw new ArgumentNullException(parameter.ParameterName, message);
            else
                return parameter;
        }
```


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

ToxicTolerance - [@Instagram](https://instagram.com/toxictolerance)

Project Link: [https://github.com/ToxicTolerance/Toxic.ParamGuard](https://github.com/ToxicTolerance/Toxic.ParamGuard)

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/ToxicTolerance/Toxic.ParamGuard.svg?style=for-the-badge
[contributors-url]: https://github.com/ToxicTolerance/Toxic.ParamGuard/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ToxicTolerance/Toxic.ParamGuard.svg?style=for-the-badge
[forks-url]: https://github.com/ToxicTolerance/Toxic.ParamGuard/network/members
[stars-shield]: https://img.shields.io/github/stars/ToxicTolerance/Toxic.ParamGuard.svg?style=for-the-badge
[stars-url]: https://github.com/ToxicTolerance/Toxic.ParamGuard/stargazers
[issues-shield]: https://img.shields.io/github/issues/ToxicTolerance/Toxic.ParamGuard.svg?style=for-the-badge
[issues-url]: https://github.com/ToxicTolerance/Toxic.ParamGuard/issues
[license-shield]: https://img.shields.io/github/license/ToxicTolerance/Toxic.ParamGuard.svg?style=for-the-badge
[license-url]: https://github.com/ToxicTolerance/Toxic.ParamGuard/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: images/screenshot.png