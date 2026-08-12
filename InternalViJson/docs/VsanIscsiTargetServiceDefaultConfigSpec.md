# Vcenter.ViJson.OpenApi.Model.VsanIscsiTargetServiceDefaultConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkInterface** | **string** | Name of default VMkernel network interface which will handle the iSCSI traffic, can be overridden per target.  The networkInterface and port need to be specified together when trying to update default VIT configuration.  | [optional] 
**Port** | **int** | Default network port, 3260 is used here, can be overridden per target.  The firewall should be opened automatically for port specified by the user. The port can be changed and need to be set together with networkInterface for default config.  | [optional] 
**IscsiTargetAuthSpec** | [**VsanIscsiTargetAuthSpec**](VsanIscsiTargetAuthSpec.md) | Default iSCSI target authentication.  If not provided, the authentication with authType None is used here.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

