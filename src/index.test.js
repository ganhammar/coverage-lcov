import { describe, it, expect } from 'vitest';
import index from './index';

describe('index', () => {
  it('is all good', () => {
    expect(index(true)).toBe('All good');
  });
});