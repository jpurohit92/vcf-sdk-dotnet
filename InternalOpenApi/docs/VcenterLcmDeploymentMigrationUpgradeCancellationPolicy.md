# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeCancellationPolicy
The Vcenter.Lcm.Deployment.MigrationUpgrade.CancellationPolicy schema defines the configuration for the upgrade cancellation policy. Some options require specific handling during the upgrade thus they need to be known in advance.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Automatic** | **bool** | Indicates that the upgrade should be automatically cancelled on error.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the system will not trigger cancel workflow on error and will wait for additional input. | [optional] 
**Method** | **List&lt;string&gt;** | Indicates which cancel methods to be used during the upgrade on the source vCenter.  Possible values:   - &#x60;CLEAN_UP&#x60;: Performs clean up on the old version vCenter. Does not result in data lost. This is the default option for the source cancellation.   For more information see: *Vcenter.Lcm.Deployment.MigrationUpgrade.CancelType*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; only the default method is used - *Vcenter.Lcm.Deployment.MigrationUpgrade.CancelType.CLEAN_UP*. | [optional] 
**SourceConnection** | [**VcenterLcmDeploymentMigrationUpgradeSourceConnection**](VcenterLcmDeploymentMigrationUpgradeSourceConnection.md) | Indicates how to communicate with the source vCenter from the target vCenter if needed.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the system will only stop the upgrade on the target vCenter but it would not put the source vCenter in operational state, once the *POST /vcenter/lcm/deployment/migration-upgrade?action&#x3D;cancel* is called post switchover from source to target vCenter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

