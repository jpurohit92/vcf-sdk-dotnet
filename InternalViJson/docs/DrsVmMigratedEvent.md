# Vcenter.ViJson.OpenApi.Model.DrsVmMigratedEvent
This event records a virtual machine migration that was recommended by DRS. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceHost** | [**HostEventArgument**](HostEventArgument.md) | The source host.  (Because this is after a successful migration, the destination host is recorded in the inherited \&quot;host\&quot; property.)  | 
**SourceDatacenter** | [**DatacenterEventArgument**](DatacenterEventArgument.md) | The source datacenter  | [optional] 
**SourceDatastore** | [**DatastoreEventArgument**](DatastoreEventArgument.md) | The source primary datastore  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

