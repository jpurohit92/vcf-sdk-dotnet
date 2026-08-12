# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeSourceConnection
The Vcenter.Lcm.Deployment.MigrationUpgrade.SourceConnection class provides the needed parameters for the target vCenter to talk with the source vCenter when there is such need.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionType** | **string** | What type of communication is to be done. The *Vcenter.Lcm.Deployment.MigrationUpgrade.ConnectionType.DIRECT* cannot be used together with *Vcenter.Lcm.Deployment.MigrationUpgrade.SourceShutdownPolicy.DURING_UPGRADE*.  Possible values:   - &#x60;DIRECT&#x60;: Communicates directly with the the desired machine on a network interface.   For more information see: *Vcenter.Lcm.Deployment.MigrationUpgrade.ConnectionType*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

