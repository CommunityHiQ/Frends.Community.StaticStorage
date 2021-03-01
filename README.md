# Frends.Community.StaticStorage

Key-value storage for storing values between process runs. Data is sored in RAM i.e. stored data is not preserved if process is updated, deployed to new environment, or if FRENDS agent is rebooted.

[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.StaticStorage/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.StaticStorage/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.StaticStorage) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [Task](#Task)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the task via FRENDS UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.StaticStorage

# Tasks

## Add
Adds or updates a key-value-pair in/to the storage
### Input 
| Property  | Type   | Description                         | Example                                  |
|-----------|--------|-------------------------------------|------------------------------------------|
| key       | string | Storage key to identify value       | `myKey` 
| value     | object | Object to add to as value           | `new { ts = DateTime.Now, desc = "something cool" }`
| overwrite | boolean| true = will overwrite existing value, false = will try to add key-value-pair as new | 

## Get

Gets keys value from storage

| Property  | Type   | Description                   | Example |
|-----------|--------|-------------------------------|---------|
| key       | string | Key of the value to get       | `myKey` |

## Remove

Removes key-value-pair from storage

| Property  | Type   | Description                | Example      |
|-----------|--------|----------------------------|--------------|
| key       | string | Storage key to remove      | `myKey` 

## Clear

Clears all key-value-pairs from storage

## ContainsKey

Checks if given key exists in storage

| Property  | Type   | Description              | Example       |
|-----------|--------|--------------------------|---------------|
| key       | string | Storage key to check     | `myKey` 

## ToJToken
Converts the whole key-value-storage to a JToken


# Building

Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.StaticStorage.git`

Rebuild the project

`dotnet build`

Run Tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 1.0.0  | Initial version |
| 1.1.0  | Multi-framework and Github actions support |
