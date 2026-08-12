# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZonesCreateSpec
The Vcenter.ConsumptionDomains.Zones.CreateSpec schema contains the information required to create a zone.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of the zone. It has the following restrictions: 1. The ID must be 63 characters or less (cannot be empty), 2. The ID must begin and end with a lowercase alphanumeric character ([a-z0-9]), 3. The ID must only contain dashes (-), and lowercase alphanumerics in between, 4. The ID must be unique within the vCenter in which it is created.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Description** | **string** | Description of the zone.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60; or empty, an empty description is set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

