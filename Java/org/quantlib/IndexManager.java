/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class IndexManager {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected IndexManager(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(IndexManager obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_IndexManager(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static IndexManager instance() {
    return new IndexManager(QuantLibJNI.IndexManager_instance(), false);
  }

  public void setHistory(String name, RealTimeSeries fixings) {
    QuantLibJNI.IndexManager_setHistory(swigCPtr, this, name, RealTimeSeries.getCPtr(fixings), fixings);
  }

  public RealTimeSeries getHistory(String name) {
    return new RealTimeSeries(QuantLibJNI.IndexManager_getHistory(swigCPtr, this, name), false);
  }

  public boolean hasHistory(String name) {
    return QuantLibJNI.IndexManager_hasHistory(swigCPtr, this, name);
  }

  public StrVector histories() {
    return new StrVector(QuantLibJNI.IndexManager_histories(swigCPtr, this), true);
  }

  public void clearHistory(String name) {
    QuantLibJNI.IndexManager_clearHistory(swigCPtr, this, name);
  }

  public void clearHistories() {
    QuantLibJNI.IndexManager_clearHistories(swigCPtr, this);
  }

}