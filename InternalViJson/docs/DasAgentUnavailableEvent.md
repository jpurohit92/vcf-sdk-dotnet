# Vcenter.ViJson.OpenApi.Model.DasAgentUnavailableEvent
Deprecated as of vSphere API 5.0, the event is no longer relevant.  This event records that VirtualCenter cannot contact any primary host in this HA cluster.  HA designates some hosts as primary hosts in the HA cluster. When adding a new host to an existing cluster, HA needs to contact one of the primary hosts to finish the configuration. VirtualCenter has lost contact with all primary nodes in the connected state. Attempts to configure HA on a host in this cluster will fail until a DasAgentFoundEvent is logged or unless this is the first node to be configured. For example, if all the other hosts are disconnected first. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

