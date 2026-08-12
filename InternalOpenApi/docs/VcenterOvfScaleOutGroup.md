# Vcenter.Automation.OpenApi.Model.VcenterOvfScaleOutGroup
The Vcenter.Ovf.ScaleOutGroup schema contains information about a scale-out group.    It allows a virtual system collection to contain a set of children that are homogeneous with respect to a prototypical virtual system or virtual system collection. It shall cause the deployment function to replicate the prototype a number of times, thus allowing the number of instantiated virtual systems to be configured dynamically at deployment time.    This is based on the ovf2:ScaleOutSection.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the scale-out group.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Description** | **string** | The description of the scale-out group.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**InstanceCount** | **long** | The scaling factor to use. It defines the number of replicas of the prototypical virtual system or virtual system collection.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**MinimumInstanceCount** | **long** | The minimum scaling factor.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. This will be 1 if there is no explicit limit. | [optional] 
**MaximumInstanceCount** | **long** | The maximum scaling factor.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. This will be missing or &#x60;null&#x60; if there is no explicit limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

