# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementProxySettingsSource
The settings can be inherited from the vCenter settings, so the cluster settings will be synced. The settings can be applied directly on the cluster level, or the cluster can be configured not to use a proxy.  Possible values:   - `VC_INHERITED`: Proxy settings will be inherited from the vCenter settings. vCenter and cluster settings will be kept in sync.   - `CLUSTER_CONFIGURED`: Proxy settings will be configured at the cluster level.   - `NONE`: No proxy settings will be applied to the cluster.   This enumeration was added in __vSphere API 7.0.3.00100__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

