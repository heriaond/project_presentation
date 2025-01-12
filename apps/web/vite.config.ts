import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react-swc';
import path from 'path';

export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: {
      // Alias for /packages file in monorepo root
      '@packages': path.resolve(__dirname, '../../packages'),

      // Alias for src file in /apps/web/src
      '@': path.resolve(__dirname, './src'),
    },
  },
});
