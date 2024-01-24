# D4C Data model
This page will document the JSON-LD schema for the exchange protocol

# json-LD format
Data is exchanged using the JSON-LD format. More info about json-LD: https://json-ld.org/.\

# Conventions
## JSON attributes
Attribute names will use the so-called camelCase style. Example: **objectName**.\
The order of words specifies the order of attributes. Example: **dId**.\
Identifiers have the **Id** suffix. Names have the **Name** suffix. Dates have the **At** suffix.
Booleans have the **is** prefix.\
Attributes of an object have the prefix **o**. Example: **oId**, **oName**.\
Attributes of a property have the prefix **p**. Example: **pId**, **pName**.

# List of fields

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
| properties[j] | 1..n | | property| objects[i].properties[j] |
| pId | 1..1 | url | identifier of the property | objects[i].properties[j].pId |
| pDict | 1..1 | string | name of the dictionary of the property | objects[i].properties[j].pDict |
| pName | 1..1 | string | name of the property | objects[i].properties[j].pName |
| pUnit | 0..1 | string | unit of the property | objects[i].properties[j].pUnit |





