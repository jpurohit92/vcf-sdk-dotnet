# Vcenter.ViJson.OpenApi.Model.VimVsanMountPrecheckTypeDITEnum
This indicates the precheck type when mounting a remote vSAN datastore and enabling remote DIT at the same time.  Possible values: - `serverClusterConsistency`: Check whether the cluster specified by remote DIT config backs up the remote datastore. - `clientRemoteDITCapability`: Check whether the client cluster has remote DIT capability. - `serverRemoteDITCapability`: Check whether the server cluster has remote DIT capability. - `rekeyIntervalValid`: Check whether the rekey interval is valid - `datastoreBelongToServerCluster`: Check whether the datastore being mounted belongs to the server cluster - `remoteDITInfoRetrieval`: Check whether remote DIT related datastore infomation can be retrieved. - `remoteDITVersionCheck`: Check whether the existing client cluster versions meet the minimum   requirement for remote DIT. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

