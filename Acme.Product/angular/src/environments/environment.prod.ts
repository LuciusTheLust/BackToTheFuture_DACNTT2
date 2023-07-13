import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Product',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44351/',
    redirectUri: baseUrl,
    clientId: 'Product_App',
    responseType: 'code',
    scope: 'offline_access Product',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44351',
      rootNamespace: 'Acme.Product',
    },
  },
} as Environment;
