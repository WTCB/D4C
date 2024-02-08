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
  
## Used ontologies
  * owl: https://www.w3.org/2002/07/owl
  * rdf: http://www.w3.org/1999/02/22-rdf-syntax-ns
  * rdfs: http://www.w3.org/2000/01/rdf-schema
  * xsd: http://www.w3.org/2001/XMLSchema

## json-LD format
Data is exchanged using the JSON-LD format. More info about [json-LD](https://json-ld.org/).

## Conventions
### JSON attributes
Attribute names will use the so-called lowerCamelCase style. Example: **hasProperty**.

## List of fields

| Field | DataType | Cardinality | Description | Path |
|----------|----------|----------|----------|----------|
| @context | URI | 1 | url (https://raw.githubusercontent.com/WTCB/D4C/main/Model/schema.jsonld) pointing to the schema definition | @context |
| object                        | [Object](#object) | 1..* |  |  |

### Object
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL or Text         |                 | Identifier of the object                                                                                  |
| reference                     | URL          | 1               | Reference to the definition of the object in a dictionary                                                                                 |
| name                          | Text       | 1..*            | Name of the object                                                                                        |
| hasProperty                      | [Property](#property) | 1..*        | Property of the object                                                                                        |
| hasRelation                     | [Relation](#relation) | 1..*        | Relation of the object                                                                                        |

### Property
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL or Text          | 1               | Identifier of the property                                                                                |
| reference                     | URL          | 1               | Reference to the definition of the property in a dictionary                                                                                 |
| name                          | Text       | 1..*            | Name of the property                                                                                      |
| value                          | Boolean, String, Number        | 1            | Value of the property                                                                                      |
| hasProperty                      | [Property](#property) | 1..*        | Connected Property of the property                                                                                        |
| hasUnit                          | [Unit](#unit)       |                 | Unit of the property                                                                                      |

### Relation
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URI          | 1               | Identifier of the relation                                                                                |
| type                          | URI          | 1               | Type of the relation                                                                                      |
| relatedObject                 | URI          | 1               | Related Object of the relation                                                                            |
| relatingObject                | URI          | 1               | Relating Object of the relation                                                                           |

### Unit
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|----------------------------------------------------------------------------------------------------------
| id                            | URI          | 1               | Identifier of the relation                                                                                |
| name                          | String       | 1..*            | Name of the property                                                                                      |
| symbol                          | String       | 1..*            | Symbol of the property                                                                                      |

