# Frends.Community.StaticStorage
Key-value storage for storing values between process runs. Data is sored in RAM i.e. stored data is not preserved if process is updated, deployed to new environment, or if FRENDS agent is rebooted.

## Building

Clone the repo
`git clone https://github.com/CommunityHiQ/Frends.Community.StaticStorage`

Switch to solution folder
`cd Frends.Community.StaticStorage`

Restores nuget packages
`nuget restore Frends.Community.StaticStorage.sln`

Build the solution in RELEASE mode

And build nuget package
`nuget pack Frends.Community.StaticStorage\Frends.Community.StaticStorage -Properties Configuration=Release`

## Documentation

### Add
Adds or updates a key-value-pair in/to the storage
#### Input 
| Property  | Type   | Description                         | Example                                   |
|-----------|--------|-------------------------------------|-------------------------------------------|
| key       | string | Storage key to identify value       | `myKey` 
| value     | object | Object to add to as value           | `new { ts = DateTime.Now, desc = "something cool" }`
| overwrite | boolean| true = will overwrite existing value, false = will try to add key-value-pair as new | 

### Get

Gets keys value from storage

| Property  | Type   | Description                   | Example |
|-----------|--------|-------------------------------|---------|
| key       | string | Key of the value to get       | `myKey` |

### Remove

Removes key-value-pair from storage

| Property  | Type   | Description                | Example      |
|-----------|--------|----------------------------|--------------|
| key       | string | Storage key to remove      | `myKey` 

### Clear

Clears all key-value-pairs from storage

### ContainsKey

Checks if given key exists in storage

| Property  | Type   | Description              | Example       |
|-----------|--------|--------------------------|---------------|
| key       | string | Storage key to check     | `myKey` 

### ToJToken
Converts the whole key-value-storage to a JToken
