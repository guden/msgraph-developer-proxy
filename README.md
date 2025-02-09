<h1 align="center">
    <img alt="Microsoft Graph Developer Proxy" src="./samples/img/graph.png" height="78" />
  <br>Microsoft Graph Developer Proxy<br>
</h1>

<h4 align="center">
  Build with Microsoft Graph. Reliably 
</h4>
 
<p align="center">
    <a href="https://github.com/microsoftgraph/msgraph-developer-proxy/releases/latest">
        <img alt="Download Now" src="https://img.shields.io/badge/download-now-green?style=for-the-badge">
    </a>
</p>

<p align="center">
  <a href="#get-started">Get started</a> |
  <a href="https://github.com/microsoftgraph/msgraph-developer-proxy/wiki/">Documentation</a>
</p>

<p align="center">
  <a href="#example">Example</a> |
  <a href="#features">Features</a> |
  <a href="#trademarks">Trademarks</a> |
  <a href="#community-preview">Community Preview</a>
</p>

<p align="center">
<video src="https://user-images.githubusercontent.com/11563347/204810331-8479815d-0d69-4793-aea6-fed737b7d15c.mp4" data-canonical-src="https://user-images.githubusercontent.com/11563347/204810331-8479815d-0d69-4793-aea6-fed737b7d15c.mp4" controls="controls" muted="muted" class="d-block rounded-bottom-2 border-top width-fit" style="max-height:640px;" autoplay>
  </video>
</p>

Microsoft Graph Developer Proxy is a command line tool for testing Microsoft Graph and other APIs.

It aims to provide a better way to test applications. 

Use the proxy to:

- simulate errors
- simulate throttling
- mock responses

Identify and fix issues in your code before they reach production.

## Get started

Begin with our [tutorial](https://github.com/microsoftgraph/msgraph-developer-proxy/wiki/Get-started). It will guide you through the installation process and running the proxy for the first time.

## Example

Fail requests (with a 50% chance) and respond with `429 Too Many Requests` or `503 Service Unavailable`:

```
mgdp --failure-rate 50 --no-mocks --allowed-errors 429 503
```

## Features

- run on any OS
  - Windows
  - macOS
  - Linux
- intercept requests from Microsoft Graph and other APIs
- simulate errors
- simulate throttling
- mock responses
- mock error responses
- define wildcard paths to serve mocked responses
- mock responses of different types (JSON, binary, etc.)
- `$select` guidance to improve performance
- non-production beta endpoint guidance for Microsoft Graph
- configure proxy to your needs, by setting:
  - failure rate
  - port
  - whether to use mock responses or not
  - URLs to intercept traffic
- record proxy activity
- get proxy activity summary report

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft trademarks or logos is subject to and must follow [Microsoft’s Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general). Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship. Any use of third-party trademarks or logos are subject to those third-party’s policies.

## Community Preview

We are working on getting the General Availability (GA) version published within the calendar year 2023. The current state of the Microsoft Graph Developer Proxy enables our team to be transparent and provide more insights on the upcoming features and to provide our worldwide ecosystem an option to directly influence the future of our capabilities. [Your feedback is more than welcome](https://github.com/microsoftgraph/msgraph-developer-proxy/issues)! You can expect many more new features within the upcoming months before a version that is officially ready for production use and fully supported.

## A Microsoft Hackathon 2022 Project

The initial build of this project was completed in the week of 5-9 September 2022 by Waldek Mastykarz, Gavin Barron and Garry Trinder

