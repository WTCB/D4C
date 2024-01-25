# D4C Data model
This page will document the JSON-LD schema for the exchange protocol

## Table of contents:
* [json-LD format](#json-ld-format)
* [Conventions](#conventions)
* [List of fields](#list-of-fields)
  * [Object](#object)
  * [Property](#property)
  * [Relation](#relation)
  * [Unit](#unit)
  
## json-LD format
Data is exchanged using the JSON-LD format. More info about [json-LD](https://json-ld.org/).

## Conventions
### JSON attributes
Attribute names will use the so-called lowerCamelCase style. Example: **objectName**.\
The order of words specifies the order of attributes. Example: **dId**.\
Identifiers have the **Id** suffix. Names have the **Name** suffix. Dates have the **At** suffix.
Booleans have the **is** prefix.\
Attributes of an object have the prefix **o**. Example: **oId**, **oName**.

## List of fields

| Field | DataType | Cardinality | Description | Path |
|----------|----------|----------|----------|----------|
| @context | URI | 1 | url pointing to the schema definition | @context |
| dicts |   | 1..1 |  | groups the referenced dictionairies | dicts |
| dicts[d] |   | 1..n |dictionary | dicts[d] |
| dId | URI | 1 | identifier of the dictionary | dicts[dId] |
| dName | String | 1..* |  name of the dictionary | dicts[dName] |
| object                        | [Object](#object) | 1..* |  |  |
| relation                      | [Relation](#relation) | 1..* |  |  |

### Object
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URI          | 1               | Identifier of the object                                                                                  |
| name                          | String       | 1..*            | Name of the object                                                                                        |
| hasProperty                      | [Property](#property) | 1..*        | Property of the object                                                                                        |

### Property
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URI          | 1               | Identifier of the property                                                                                |
| name                          | String       | 1..*            | Name of the property                                                                                      |
| value                          |        | 1            | Value of the property                                                                                      |
| hasUnit                          | [Unit](#unit)       |                 | Unit of the property                                                                                      |

### Relation
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URI          | 1               | Identifier of the relation                                                                                |
| type                          | URI          | 1               | Type of the relation                                                                                      |
| relatedObject                 | URI          | 1               | Related Object of the relation                                                                            |
| relatingObject                | URI          | 1               | Relating Object of the relation                                                                           |

### Unit




