# D4C Data model
This page will document the JSON-LD schema for the exchange protocol

## Table of contents:
* [json-LD format](#json-ld-format)
* [Conventions](#conventions)
* [List of fields](#list-of-fields)
  * [Object](#object)
  * [Property](#property)
  * [Relation](#relation)
  
## json-LD format
Data is exchanged using the JSON-LD format. More info about [json-LD](https://json-ld.org/).

## Conventions
### JSON attributes
Attribute names will use the so-called lowerCamelCase style. Example: **objectName**.\
The order of words specifies the order of attributes. Example: **dId**.\
Identifiers have the **Id** suffix. Names have the **Name** suffix. Dates have the **At** suffix.
Booleans have the **is** prefix.\
Attributes of an object have the prefix **o**. Example: **oId**, **oName**.\

## List of fields

| Key | Occurence (specifies if optional or not) | Format | Comment | Path |
|----------|----------|----------|----------|----------|
| @context | 1..n | url | url pointing to the schema definition | @context |
| dicts | 1..1 |  | groups the referenced dictionairies | dicts |
| dicts[d] | 1..n |  | dictionary | dicts[d] |
| dId | 1..1 | url | identifier of the dictionary | dicts[dId] |
| dName | 1..1 | string | name of the dictionary | dicts[dName] |
| objects | 1..1 |  | groups the objects | objects[i] |
| objects[i] | 1..n |  | object | objects[i] |
| oId | 1..1 | url | identifier of the object | objects[i].oId |
| oName | 1..1 | string | name of the object | objects[i].Name |
| properties | 1..1 | | groups the properties of the object | objects[i].properties |
| properties[j] | 1..n | | [Property](#property) | objects[i].properties[j] |

### Object
| Field                         | DataType     | Description                                                                                               |
|-------------------------------|--------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL          | Identifier of the object                                                                                  |
### Property
| Field                         | DataType     | Description                                                                                               |
|-------------------------------|--------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL          | Identifier of the property                                                                                |
| dictionary                    | String       | name of the dictionary of the property                                                                                      |
| name                          | String       | name of the property                                                                                      |
| unit                          | String       | unit of the property                                                                                      |
### Relation
| Field                         | DataType     | Description                                                                                               |
|-------------------------------|--------------|-----------------------------------------------------------------------------------------------------------|




