# Vcenter.ViJson.OpenApi.Model.HostSgxRegistrationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | SGX host registration status.  Valid values come from *HostSgxRegistrationInfoRegistrationStatus_enum* enum. Set, except in case of an internal error.  | [optional] 
**BiosError** | **int** | BIOS error related to SGX host registration.  Set only if SGX registration status is incomplete.  | [optional] 
**RegistrationUrl** | **string** | SGX host registration URL.  Unset if SGX registration status is not applicable or in case of an internal error.  | [optional] 
**Type** | **string** | SGX host registration type.  Valid values come from *HostSgxRegistrationInfoRegistrationType_enum* enum. Unset if SGX registration status is not applicable, complete, or in case of an internal error.  | [optional] 
**Ppid** | **string** | Platform Provisioning ID (PPID).  Hex-encoded representation of the the PPID (Platform Provisioning ID), returned as the response to a successful registration request. This field is populated only on the vCenter through which the host has been registered.  | [optional] 
**LastRegisteredTime** | **DateTime** | Timestamp of last successful registration from this vCenter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

